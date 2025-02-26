using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.DTOs.Departments
{
    public class ReadDepartmentDTO
    {
        public int Dept_Id { get; set; }

        [StringLength(50)]
        public string Dept_Name { get; set; }

        [StringLength(100)]
        public string Dept_Desc { get; set; }

        [StringLength(50)]
        public string Dept_Location { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Manager_hiredate { get; set; }
        public int NumberOfStudents { get; set; }
    }
}
