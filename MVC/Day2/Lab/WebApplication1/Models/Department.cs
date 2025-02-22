using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Models
{
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Remote("IsUniqueID", controller: "Department")]
        public int Id { get; set; }
        [StringLength(10, MinimumLength = 2)]
        [Required]
        [Remote("IsUniqueName", controller: "Department")]
        public string Name { get; set; }
        public int Capacity { get; set; }
        public bool Status { get; set; } = true;
        public virtual ICollection<Student> Students { get; set; }
    }
}
