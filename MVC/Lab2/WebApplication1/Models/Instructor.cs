// Ignore Spelling: Crs

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Instructor")]
    public class ClsInstructor
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Image { get; set; }
        public float Salary { get; set; }
        [Required]
        [MaxLength(100)]
        public string Address { get; set; }
        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        [ForeignKey("Course")]
        public int Crs_Id { get; set; }
        public ClsDepartment Department { get; set; }
        public ClsCourse Course { get; set; }
    }
}
