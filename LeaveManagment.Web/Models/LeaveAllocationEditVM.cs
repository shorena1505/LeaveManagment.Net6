using LeaveManagment.Web.Data;

namespace LeaveManagment.Web.Models
{
    public class LeaveAllocationEditVM: LeaveAllocationVM
    {
        public string EmployeeId { get; set; }
       
        public List<LeaveAllocationVM>? LeaveAllocations { get; set; }

        public EmployeeListVM? Employee { get; internal set; }
    }
}
