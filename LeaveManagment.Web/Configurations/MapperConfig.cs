using AutoMapper;
using LeaveManagment.Web.Data;
using LeaveManagment.Web.Models;
using Microsoft.Build.Framework.Profiler;

namespace LeaveManagment.Web.Configurations
{
    public class MapperConfig : Profile
    {
       public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            CreateMap<Employee, EmployeeListVM>().ReverseMap();
            CreateMap<Employee, EmployeeAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationEditVM>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestCreateVM>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestVM>().ReverseMap();

        }
    }
}
