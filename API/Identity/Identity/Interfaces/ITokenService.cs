using Identity.DTOs.Account;
using Identity.Model;

namespace Identity.Interfaces
{
    public interface ITokenService
    {
        Task<AuthDto> CreateToken(AppUser user);
    }
}
