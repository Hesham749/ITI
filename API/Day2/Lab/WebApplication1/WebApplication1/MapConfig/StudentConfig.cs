using AutoMapper;
using WebApplication1.DTOs.Students;
using WebApplication1.Models;

namespace WebApplication1.MapConfig
{
    public class StudentConfig : Profile
    {
        public StudentConfig()
        {
            CreateMap<Student, ReadStudentDTO>().AfterMap((s, d) =>
            {
                d.Department = s.Dept.Dept_Name;
                d.supervisor = s.St_superNavigation?.St_Fname;
            }).ReverseMap();
        }
    }
}
