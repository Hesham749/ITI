using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(20)]
        [Remote("MailValidation", controller: "Student", AdditionalFields = "Id")]
        public string Mail { get; set; }
        [Required]
        [StringLength(12, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string CPassword { get; set; }

        [ForeignKey("Department")]
        public int DeptID { get; set; }
        public virtual Department Department { get; set; }
    }
}
