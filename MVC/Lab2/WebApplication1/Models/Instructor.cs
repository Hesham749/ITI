// Ignore Spelling: Crs

using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Instructor")]
    public class ClsInstructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public float Salary { get; set; }
        public string Address { get; set; }
        public int Dept_Id { get; set; }
        public int Crs_Id { get; set; }
        public ClsDepartment Department { get; set; }
        public ClsCourse Course { get; set; }
    }
}
