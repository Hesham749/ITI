// Ignore Spelling: Crs

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Instructor")]
    public class ClsInstructor
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public required string Name { get; set; }
        [MaxLength(100)]
        public string? Image { get; set; }
        public float Salary { get; set; }
        [MaxLength(100)]
        public required string Address { get; set; }
        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        [ForeignKey("Course")]
        public int Crs_Id { get; set; }
        public virtual required ClsDepartment Department { get; set; }
        public virtual required ClsCourse Course { get; set; }
    }
}
