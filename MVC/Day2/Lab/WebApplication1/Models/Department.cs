using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [StringLength(10, MinimumLength = 2)]
        [Required]
        public string Name { get; set; }
        public int Capacity { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
