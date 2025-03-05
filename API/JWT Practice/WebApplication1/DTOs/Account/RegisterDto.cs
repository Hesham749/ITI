using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTOs.Account
{
    public class RegisterDto
    {
        public string UserName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
