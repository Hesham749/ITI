using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Identity.DTOs.Account;
using Identity.Interfaces;
using Identity.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace Identity.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _config;
        private readonly SymmetricSecurityKey _key;
        private readonly UserManager<AppUser> _userManager;
        public TokenService(IConfiguration config, UserManager<AppUser> userManager)
        {
            _config = config;
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            _userManager = userManager;
        }
        public async Task<AuthDto> CreateToken(AppUser user)
        {
            var userClaims = new List<Claim>
            {
                new(ClaimTypes.NameIdentifier,user.Id),
                new(ClaimTypes.Name, user.UserName) ,
                new (JwtRegisteredClaimNames.Email, user.Email),
                new(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };
            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                userClaims.Add(new(ClaimTypes.Role, role));
            }

            var creds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken
            (
                claims: userClaims,
                signingCredentials: creds,
                expires: DateTime.Now.AddDays(double.Parse(_config["Jwt:Expires"])),
                issuer: _config["Jwt:Issuer"],
                audience: _config["jwt:Audience"]
            );
            var tokenHandler = new JwtSecurityTokenHandler();
            return new() { Email = user.Email, UserName = user.UserName, Token = tokenHandler.WriteToken(token), ExpiresOn = token.ValidTo };
        }
    }
}
