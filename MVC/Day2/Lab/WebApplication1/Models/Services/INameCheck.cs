namespace WebApplication1.Models.Services
{
    public interface INameCheck
    {
        bool IsUniqueName(string Name, int id);
    }
}
