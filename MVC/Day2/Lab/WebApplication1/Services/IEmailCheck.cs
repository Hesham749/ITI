namespace WebApplication1.Services
{
    public interface IEmailCheck
    {
        bool IsUniqueMail(string mail, int id);
    }
}
