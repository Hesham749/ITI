using System.Security.Claims;
using System.Text;
using Identity.Interfaces;
using Identity.Model;
using Microsoft.IdentityModel.Tokens;

namespace Identity.Services
{
    public class TokenService : ITokenServer
    {
        private readonly IConfiguration _config;
        private readonly SymmetricSecurityKey _key;
        public TokenService(IConfiguration config)
        {
            _config = config;
            _key = new(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        }
        public string CreateToken(AppUser user)
        {
            var claims = new List<Claim> { };
        }
    }
}
