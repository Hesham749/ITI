// Ignore Spelling: Crs

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class ClsTrainee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Image { get; set; }
        public int Grade { get; set; }
        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        public ClsDepartment Department { get; set; }
        public virtual ICollection<ClsCrsResult> CrsResults { get; set; } = [];
    }
}
