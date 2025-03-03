namespace APiWithJWT.Model
{
    public class AuthModel
    {
        public string Message { get; set; }
        public bool IsAuthenticated { get; set; }
        public string UserName { get; set; }
        public List<string> Roles { get; set; }
        public string EMail { get; set; }
        public string Token { get; set; }
        public DateTime ExpiresOn { get; set; }
    }
}
