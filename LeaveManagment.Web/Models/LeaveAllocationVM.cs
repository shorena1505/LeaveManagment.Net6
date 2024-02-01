using System.ComponentModel.DataAnnotations;

namespace LeaveManagment.Web.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }
        [Display(Name = "Number of Days")]
        [Required]
        [Range(1, 30, ErrorMessage ="Invalid Number Entered")]
        public int NumberOfDays { get; set; }
        [Required]
        public int Period {  get; set; }        
        public LeaveTypeVM? LeaveType { get; set; }
    }
}