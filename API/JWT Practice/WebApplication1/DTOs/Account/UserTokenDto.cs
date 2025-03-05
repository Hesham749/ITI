namespace WebApplication1.DTOs.Account
{
    public class UserTokenDto
    {
        public string UserName { get; set; }
        public string ID { get; set; }
        public string Token { get; set; }
        public DateTime ExpiresOn { get; set; }
    }
}
