using APiWithJWT.Model;

namespace APiWithJWT.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(LoginModel model);
        Task<string> AddToRoleAsync(AddToRoleModel model);
    }
}
