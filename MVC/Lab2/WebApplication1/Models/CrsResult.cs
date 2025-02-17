// Ignore Spelling: Crs

using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("CrsResult")]
    public class ClsCrsResult
    {
        public int Id { get; set; }
        public  int Degree { get; set; }
        [ForeignKey("Course")]
        public  int Crs_Id { get; set; }
        [ForeignKey("Trainee")]
        public int Trainee_Id { get; set; }
        public virtual required ClsCourse Course { get; set; }
        public virtual required ClsTrainee Trainee { get; set; }
    }
}
