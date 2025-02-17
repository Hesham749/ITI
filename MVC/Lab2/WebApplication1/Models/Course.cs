// Ignore Spelling: Crs

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Course")]
    public class ClsCourse
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public required string Name { get; set; }
        public int Degree { get; set; }
        public int Hours { get; set; }
        public int MinDegree { get; set; }
        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        public virtual  ClsDepartment  Department { get; set; }
        public virtual ICollection<ClsInstructor> Instructors { get; set; } = [];
        public virtual ICollection<ClsCrsResult> CrsResults { get; set; } = [];

    }
}
