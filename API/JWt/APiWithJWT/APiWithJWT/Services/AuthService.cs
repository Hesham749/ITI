using APiWithJWT.Helper;
using APiWithJWT.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace APiWithJWT.Services
{
    public class AuthService : IAuthService
    {

        public AuthService(UserManager<IdentityUser> UserManager, RoleManager<IdentityRole> RoleManager, IOptions<Jwt> jwt)
        {
            this.UserManager = UserManager;
            this.RoleManager = RoleManager;
            Jwt = jwt;
        }

        public UserManager<IdentityUser> UserManager { get; }
        public RoleManager<IdentityRole> RoleManager { get; }
        public IOptions<Jwt> Jwt { get; }

        public async Task<string> AddToRoleAsync(AddToRoleModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<AuthModel> GetTokenAsync(LoginModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<AuthModel> RegisterAsync(RegisterModel model)
        {
            if (await UserManager.FindByNameAsync(model.UserName) is not null)
                return new AuthModel { Message = "User Name is already register" };
            if (await UserManager.FindByEmailAsync(model.Email) is not null)
                return new AuthModel { Message = "Email is already register" };
            var User = new IdentityUser
            {
                UserName = model.UserName,
                Email = model.Email,
            };
            var result = await UserManager.CreateAsync(User, model.Password);
            if (!result.Succeeded)
            {
                List<string> errors = [];
                foreach (var error in result.Errors)
                {
                    errors.Add(error.Description);
                }
                return new AuthModel { Message = string.Join(" , ", errors) };
            }
            await UserManager.AddToRoleAsync(User, "User");
            await UserManager.CreateSecurityTokenAsync(User);
            return new AuthModel { };

        }

        //public async Task<JwtSecurityToken> CreateJwtTokenAsync()
        //{

        //}
    }
}
