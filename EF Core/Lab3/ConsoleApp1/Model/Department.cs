using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Model
{
    [Table("Department")]
    public class ClsDepartment
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string Name { get; set; }
        public ICollection<ClsEmployee> Employees { get; set; }
        public ICollection<ClsEmployee> Supers { get; set; }

    }
}
