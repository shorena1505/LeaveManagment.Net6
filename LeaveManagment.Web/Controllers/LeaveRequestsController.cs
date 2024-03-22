using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagment.Web.Data;
using LeaveManagment.Web.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using LeaveManagment.Web.Constans;
using Microsoft.AspNetCore.Authorization;
using NuGet.Protocol.Core.Types;

namespace LeaveManagment.Web.Controllers
{
    [Authorize]
    public class LeaveRequestsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<Employee> userManager;
        private readonly ILogger<LeaveRequestsController> logger;
        private EventId ex;

        public LeaveRequestsController(ApplicationDbContext context, IMapper mapper,
            IHttpContextAccessor httpContextAccessor, UserManager<Employee> userManager, ILogger<LeaveRequestsController> logger)
        {
            _context = context;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            this.userManager = userManager;
            this.logger = logger;
        }

        [Authorize(Roles=Roles.Administrator)]
        // GET: LeaveRequests
        public async Task<IActionResult> Index()
        {
            var leaveRequests = await _context.LeaveRequests.ToListAsync();
            var model = new AdminLeaveRequestViewVM
            {
                TotalRequests = leaveRequests.Count,
                ApprovedRequests = leaveRequests.Count(q => q.Approved == true),
                PendingRequests = leaveRequests.Count(q => q.Approved == null),
                RejectedRequests = leaveRequests.Count(q => q.Approved == false),
                CancelRequests = leaveRequests.Count(q => q.Cancelled == true),
                LeaveRequests = mapper.Map<List<LeaveRequestVM>>(leaveRequests)
            };
            return View(model);
        }

        public async Task<IActionResult> GetMyLeaveDetails()
        {
            var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);
            var leaveRequests = await _context.LeaveRequests
                .Where(l => l.RequestingEmployeeId == user.Id)
                .Include(l => l.LeaveType)
                .ToListAsync();

            // Pass the leave requests to the view for display
            return View(leaveRequests);
        }

        public async Task<IActionResult> MyLeave()
        {
            var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);

            // Map leave requests to view models
            var leaveRequests = await _context.LeaveRequests
                .Where(l => l.RequestingEmployeeId == user.Id)
                .Include(l => l.LeaveType)
                .ToListAsync();

            var leaveRequestVMs = mapper.Map<List<LeaveRequestVM>>(leaveRequests);

            // Create an instance of EmployeeLeaveRequestViewVM without EmployeeId
            var employeeLeaveRequestView = new EmployeeLeaveRequestViewVM
            {
                LeaveRequests = leaveRequestVMs
            };

            // Pass the EmployeeLeaveRequestViewVM instance to the view for display
            return View(employeeLeaveRequestView);
        }

        public async Task<IActionResult> GetAdminLeaveRequestList()
        {
            var leaveRequests = await _context.LeaveRequests.ToListAsync();
            var model = new AdminLeaveRequestViewVM
            {
                TotalRequests = leaveRequests.Count,
                ApprovedRequests = leaveRequests.Count(q => q.Approved == true),
                PendingRequests = leaveRequests.Count(q => q.Approved == null),
                RejectedRequests = leaveRequests.Count(q => q.Approved == false),
                CancelRequests = leaveRequests.Count(q => q.Cancelled == true),
                LeaveRequests = mapper.Map<List<LeaveRequestVM>>(leaveRequests)
            };

            // Return the model
            return View(model);
        }

        // GET: LeaveRequestsApprove/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.LeaveRequests == null)
            {
                return NotFound();
            }

            var leaveRequest = await _context.LeaveRequests
                .Include(l => l.LeaveType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leaveRequest == null)
            {
                return NotFound();
            }

            var model = mapper.Map<LeaveRequestVM>(leaveRequest);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(int id, bool approved)
        {
            try
            {
                var leaveRequests = await _context.LeaveRequests
                .Include(l => l.LeaveType)
                .FirstOrDefaultAsync(l => l.Id == id);
            
                if (leaveRequests == null)
                {
                    return NotFound();
                }
                // Update the approval status of the leave request
                leaveRequests.Approved = approved;
                leaveRequests.Cancelled = false;
                

                // Save changes to the database
                await _context.SaveChangesAsync();

                // Redirect to the index action after successful approval
                return RedirectToAction(nameof(MyLeave));

            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error Approving Request");
                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cancel(int id)
        {
            // Retrieve the leave request from the database asynchronously
            var leaveRequest = _context.LeaveRequests.FirstOrDefaultAsync(lr => lr.Id == id).Result;

            if (leaveRequest == null)
            {
                // If leave request not found, return NotFound result
                return NotFound();
            }

            // Mark the leave request as canceled
            leaveRequest.Cancelled = true;
            leaveRequest.Approved = false;

            try
            {
                // Update the leave request in the database synchronously
                _context.LeaveRequests.Update(leaveRequest);
                _context.SaveChangesAsync();

                // Redirect to the appropriate action or page
                return RedirectToAction(nameof(MyLeave));
            }
            catch (Exception ex)
            {
                // Log any errors that occur during cancellation
                logger.LogError(ex, "Error occurred while canceling leave request with ID {LeaveRequestId}", id);

                // Redirect to an error page or display an error message
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: LeaveRequests/Create
        public IActionResult Create()
        {
            var model = new LeaveRequestCreateVM
            {
                LeaveTypes = new SelectList(_context.LeaveTypes, "Id", "Name")
            };
           return View(model);
        }

        // POST: LeaveRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveRequestCreateVM model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);
                    LeaveRequest leaveRequest = mapper.Map<LeaveRequestCreateVM, LeaveRequest>(model);
                    leaveRequest.DateRequested=DateTime.Now;
                    leaveRequest.RequestingEmployeeId=user.Id;

                    // Add the mapped leaveRequest to the context
                    _context.LeaveRequests.Add(leaveRequest);

                    // Save changes to the database
                    await _context.SaveChangesAsync();

                    // Redirect to the index action after successful creation
                    return RedirectToAction(nameof(MyLeave));
                }
                catch (Exception)
                {
                    logger.LogError(ex, "Error Cancelling Leave request");
                    ModelState.AddModelError("", "An error occurred while processing your request.");
                    return View(model);
                }
            }
            model.LeaveTypes = new SelectList(_context.LeaveTypes, "Id", "Name", model.LeaveTypeId);
            return View(model);
        }

        // GET: LeaveRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.LeaveRequests == null)
            {
                return NotFound();
            }

            var leaveRequest = await _context.LeaveRequests.FindAsync(id);
            if (leaveRequest == null)
            {
                return NotFound();
            }
            ViewData["LeaveTypeId"] = new SelectList(_context.LeaveTypes, "Id", "Id", leaveRequest.LeaveTypeId);
            return View(leaveRequest);
        }

        // POST: LeaveRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StartDate,EndDate,LeaveTypeId,DateRequested,RequestComments,Approved,Cancelled,RequestingEmployeeId,Id,DateCreated,DateModified")] LeaveRequest leaveRequest)
        {
            if (id != leaveRequest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leaveRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeaveRequestExists(leaveRequest.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(MyLeave));
            }
            ViewData["LeaveTypeId"] = new SelectList(_context.LeaveTypes, "Id", "Id", leaveRequest.LeaveTypeId);
            return View(leaveRequest);
        }

        // GET: LeaveRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.LeaveRequests == null)
            {
                return NotFound();
            }

            var leaveRequest = await _context.LeaveRequests
                .Include(l => l.LeaveType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leaveRequest == null)
            {
                return NotFound();
            }

            return View(leaveRequest);
        }

        // POST: LeaveRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.LeaveRequests == null)
            {
                return Problem("Entity set 'ApplicationDbContext.LeaveRequests'  is null.");
            }
            var leaveRequest = await _context.LeaveRequests.FindAsync(id);
            if (leaveRequest != null)
            {
                _context.LeaveRequests.Remove(leaveRequest);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(MyLeave));
        }

        private bool LeaveRequestExists(int id)
        {
          return (_context.LeaveRequests?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
