using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApplication1.DTOs.Students
{
    public class ReadStudentDTO
    {
        public int St_Id { get; set; }

        [StringLength(50)]
        public string St_Fname { get; set; }

        [StringLength(10)]
        public string St_Lname { get; set; }

        [StringLength(100)]
        public string St_Address { get; set; }

        public int? St_Age { get; set; }

        public string Department { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string supervisor { get; set; }
    }
}
