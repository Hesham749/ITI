using System.ComponentModel.DataAnnotations;

namespace Day1.DTOs.StudentDTO
{
    public class AddStudentDTO
    {
        [Required]
        public string name { get; set; }
        [MaxLength(100)]
        public string address { get; set; }
        public int age { get; set; }
        public int deptid { get; set; }
    }
}
