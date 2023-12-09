using AutoMapper;
using LeaveManagment.Web.Data;
using LeaveManagment.Web.Models;
using Microsoft.Build.Framework.Profiler;

namespace LeaveManagment.Web.Configurations
{
    public class MapperConfiguration : Profile
    {
       public MapperConfiguration()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
