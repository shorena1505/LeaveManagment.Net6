using System.ComponentModel.DataAnnotations;

namespace LeaveManagment.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "LeaveType Name")]
        [Required]
        public string? Name { get; set; }

        [Display(Name = "Default Numbers Of Days")]
        [Range(1, 30, ErrorMessage = "Number of days must be between 1 and 30.")]
        [Required]
        public int DefaultDays { get; set; }
    }
}
