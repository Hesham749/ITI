using AutoMapper;
using Day1.DTOs.DepartmentDTO;
using Day1.DTOs.StudentDTO;
using Day1.Models;

namespace Day1.MapperConfig
{
    public class mappconfig:Profile
    {
        public mappconfig()
        {
            CreateMap<Student, ReadStudentDTO>().AfterMap((src, dest) =>
            {
                dest.address = src.adddress;
                dest.departmentName = src?.dept?.name;
              //  dest.age = src.age + 1;
            }).ReverseMap();
            CreateMap<Student, AddStudentDTO>().ReverseMap();

            CreateMap<Department, ReadDepartmentDTO>().AfterMap((src, dest) => {
                dest.location = src.Loc;
                dest.studentNames = src.Students.Select(n => n.name).ToList();
            
            }).ReverseMap();
        }
    }
}
