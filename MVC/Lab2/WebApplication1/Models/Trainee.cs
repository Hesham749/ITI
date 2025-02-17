// Ignore Spelling: Crs

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Trainee")]
    public class ClsTrainee
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public required string Name { get; set; }
        [MaxLength(100)]
        public string? Image { get; set; }
        public int Grade { get; set; }
        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        public virtual required ClsDepartment Department { get; set; }
        public virtual ICollection<ClsCrsResult> CrsResults { get; set; } = [];
    }
}
