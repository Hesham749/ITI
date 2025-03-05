namespace WebApplication1.Helper
{
    public class Jwt
    {
        public string Key { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public Double ExpireInDays { get; set; }
    }
}
