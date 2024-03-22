using LeaveManagment.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagment.Web.Models
{
    public enum Statuses
    {
        Pending = 1,
        Approved = 20,
        Rejected = 30,
        Cacelled = 40
    }

    public class LeaveRequestVM : LeaveRequestCreateVM
    {
        public int Id { get; set; }
        [Display(Name = "Date Requested")]
        public DateTime DateRequested { get; set; }

        [Display(Name = "Leave Type")]
        public LeaveTypeVM LeaveType { get; set; }


        // public Statuses Status { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }

        public EmployeeListVM Employee { get; set; }

    }
}
