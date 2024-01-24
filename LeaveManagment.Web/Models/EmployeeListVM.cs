using System.ComponentModel.DataAnnotations;

namespace LeaveManagment.Web.Models
{
    public class EmployeeListVM
    {
        public string Id { get; set; }
       
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
      
        public string Email { get; set; }
       
        [Display(Name = "Date Of Joined")]
        public string DateOfJoin { get; set; }


    }
}
