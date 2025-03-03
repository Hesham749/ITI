using Identity.Model;

namespace Identity.Interfaces
{
    public interface ITokenServer
    {
        string CreateToken(AppUser user);
    }
}
