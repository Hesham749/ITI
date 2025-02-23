namespace WebApplication1.Models.Services
{
    public interface IEmailCheck
    {
        bool IsUniqueMail(string mail, int id);
    }
}
