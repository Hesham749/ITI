using AutoMapper;
using WebApplication1.DTOs.Departments;
using WebApplication1.Models;

namespace WebApplication1.MapConfig
{
    public class DepartmentConfig : Profile
    {
        public DepartmentConfig()
        {
            CreateMap<Department, ReadDepartmentDTO>().AfterMap((s, d) =>
            {
                d.NumberOfStudents = s.Students.Count();

            }).ReverseMap();
        }
    }
}
