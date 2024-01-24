using AutoMapper;
using LeaveManagment.Web.Constans;
using LeaveManagment.Web.Data;
using LeaveManagment.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagment.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Employee> userManager;
        private readonly IMapper mapper;


        public EmployeesController(UserManager<Employee> userManager, IMapper mapper, ApplicationDbContext context)
        {
            this.context = context;
            this.userManager = userManager;
            this.mapper = mapper;

        }

        // GET: EmployeesController
        public async Task<IActionResult> Index()
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var model = mapper.Map<List<EmployeeListVM>>(employees);
            return View(model);
        }
        // Assuming 'context' is your DbContext injected into the controller
        public async Task<IActionResult> ViewAllocation(string id)
        {
            if (context == null)
            {
                // Log or handle the case when context is null
                return NotFound("Context is null");
            }
            var allocations = await context.LeaveAllocations
                    .Where(q => q.EmployeeId == id)
                    .Select(q => new LeaveAllocationVM
                    {
                        Id = q.Id,
                        NumberOfDays = q.NumberOfDays,
                        Period = q.Period,
                        LeaveType = mapper.Map<LeaveTypeVM>(q.LeaveType),
                    })
                    .ToListAsync();

            var employee = await userManager.FindByIdAsync(id); // Use the id parameter
            var employeeAllocationModel = mapper.Map<EmployeeAllocationVM>(employee);
            employeeAllocationModel.LeaveAllocations = mapper.Map<List<LeaveAllocationVM>>(allocations);
             return View(employeeAllocationModel);
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/EditAllocation/5
        public async Task<ActionResult> EditAllocation(int id)
        {
            Console.WriteLine($"Received id: {id}");
            var leaveAllocation = await context.LeaveAllocations.FindAsync(id);

            if (leaveAllocation == null)
            {
                // Optionally, you can redirect to an error page or return a specific view for not found cases
                return NotFound($"Leave allocation with ID {id} not found.");
            }

            var model = mapper.Map<LeaveAllocationEditVM>(leaveAllocation);
            return View(model);
        }

        // POST: EmployeesController/ EditAllocations/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAllocation(int id, LeaveAllocationEditVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Retrieve the original LeaveAllocation from the database
                    var leaveAllocation = await context.LeaveAllocations.FindAsync(id);

                    if (leaveAllocation == null)
                    {
                        // Optionally, you can redirect to an error page or return a specific view for not found cases
                        return NotFound($"Leave allocation with ID {id} not found.");
                    }

                    // Update the LeaveAllocation with the values from the submitted form
                    // For simplicity, you can use AutoMapper or manually update the properties
                    leaveAllocation.Id= model.Id;
                    leaveAllocation.NumberOfDays = model.NumberOfDays;
                    leaveAllocation.Period = model.Period;

                    // Save changes to the database
                    await context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelState.AddModelError(string.Empty, "An Error Has Occurred, Please Try Again Later");
            }

            var dbEmployee = await userManager.FindByIdAsync(model.EmployeeId);
            if (dbEmployee != null)
            {
                // Correct the assignment of properties
                model.Employee = new EmployeeListVM
                {
                    Id = dbEmployee.Id,
                    FirstName = dbEmployee.FirstName,
                    LastName = dbEmployee.LastName,
                    Email = dbEmployee.Email,
                    DateOfJoin = dbEmployee.DateOfJoin.ToString("yyyy-MM-dd")
                };
            }

            return View(model);

        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
