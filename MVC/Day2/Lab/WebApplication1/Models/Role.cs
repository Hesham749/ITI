using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Role
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual List<User> Users { get; set; } = [];
    }
}
