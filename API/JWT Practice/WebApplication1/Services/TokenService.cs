using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using WebApplication1.Data;
using WebApplication1.DTOs.Account;
using WebApplication1.Interfaces;

namespace WebApplication1.Services
{
    public class TokenService : ITokenService
    {
        readonly UserManager<AppUser> _userManager;
        readonly SymmetricSecurityKey _key;
        readonly IConfiguration _config;
        public TokenService(UserManager<AppUser> userManager, IConfiguration config)
        {
            _userManager = userManager;
            _config = config;
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        }

        public async Task<UserTokenDto> CreateToken(AppUser user)
        {
            var userClaims = new List<Claim>
            {
                new(ClaimTypes.NameIdentifier,user.Id),
                new(ClaimTypes.Name , user.UserName),
                new(JwtRegisteredClaimNames.Jti , Guid.NewGuid().ToString())
            };

            var userRoles = await _userManager.GetRolesAsync(user);
            foreach (var role in userRoles)
            {
                userClaims.Add(new(ClaimTypes.Role, role));
            }

            var cred = new SigningCredentials(_key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: userClaims,
                signingCredentials: cred,
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                expires: DateTime.Now.AddDays(double.Parse(_config["Jwt:ExpireInDays"]))
                );
            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
            return new()
            {
                ID = user.Id,
                Token = tokenString,
                UserName = user.UserName,
                ExpiresOn = token.ValidTo
            };
        }
    }
}
