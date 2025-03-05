using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using WebApplication1.Data;
using WebApplication1.DTOs.Account;
using WebApplication1.Helper;
using WebApplication1.Interfaces;

namespace WebApplication1.Services
{
    public class TokenService : ITokenService
    {
        readonly UserManager<AppUser> _userManager;
        readonly SymmetricSecurityKey _key;
        readonly Jwt _jwt;
        public TokenService(UserManager<AppUser> userManager, IOptions<Jwt> jwt)
        {
            _userManager = userManager;
            _jwt = jwt.Value;
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));
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
                issuer: _jwt.Issuer,
                audience: _jwt.Audience,
                expires: DateTime.Now.AddDays(_jwt.ExpireInDays)
                );
            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
            return new()
            {
                ID = user.Id,
                Token = tokenString,
                UserName = user.UserName,
                ExpiresOn = token.ValidTo,
                Roles = userRoles.ToList()
            };
        }
    }
}
