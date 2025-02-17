using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Department")]
    public class ClsDepartment
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public required string Name { get; set; }
        [MaxLength(30)]
        public string? Manager { get; set; }
        public virtual ICollection<ClsInstructor> Instructors { get; set; } = [];
        public virtual ICollection<ClsCourse> Courses { get; set; } = [];
        public virtual ICollection<ClsTrainee> Trainees { get; set; } = [];

    }
}
