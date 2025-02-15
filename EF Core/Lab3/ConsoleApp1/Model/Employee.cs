using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Model
{
    [Table("Employee")]
    public class ClsEmployee
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string Name { get; set; }
        public int DeptId { get; set; }
        public ClsDepartment Department { get; set; }
        public ClsDepartment MangedDepartment { get; set; }
    }
}
