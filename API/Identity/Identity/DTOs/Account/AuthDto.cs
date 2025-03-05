using System.ComponentModel.DataAnnotations;

namespace Identity.DTOs.Account
{
    public class AuthDto
    {
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public DateTime ExpiresOn { get; set; }
    }
}
