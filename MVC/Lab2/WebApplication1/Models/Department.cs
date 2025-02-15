using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Department")]
    public class ClsDepartment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
        public ICollection<ClsInstructor> Instructors { get; set; }
        public ICollection<ClsCourse> Courses { get; set; }
        public ICollection<ClsTrainee> Trainee { get; set; }

    }
}
