﻿namespace LeaveManagment.Web.Models
{
    public class EmployeeLeaveRequestViewVM
    {
        public List<LeaveAllocationVM> LeaveAllocations { get; set; } = new List<LeaveAllocationVM>();
        public List<LeaveRequestVM> LeaveRequests { get; set; } = new List<LeaveRequestVM>();
    }
}
