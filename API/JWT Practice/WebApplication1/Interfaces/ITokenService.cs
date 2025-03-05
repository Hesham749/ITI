using WebApplication1.Data;
using WebApplication1.DTOs.Account;

namespace WebApplication1.Interfaces
{
    public interface ITokenService
    {
        Task<UserTokenDto> CreateToken(AppUser user);
    }
}
