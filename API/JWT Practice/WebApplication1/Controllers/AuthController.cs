using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.DTOs.Account;
using WebApplication1.Interfaces;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        readonly ITokenService _service;
        readonly UserManager<AppUser> _userManager;

        public AuthController(UserManager<AppUser> userManager, ITokenService service)
        {
            _userManager = userManager;
            _service = service;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<UserTokenDto>> Register([FromBody] RegisterDto registerDto)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var user = new AppUser
            {
                UserName = registerDto.UserName,
                Email = registerDto.Email
            };
            var createdUser = await _userManager.CreateAsync(user, registerDto.Password);
            if (createdUser.Succeeded)
            {
                var addRole = await _userManager.AddToRoleAsync(user, "User");
                if (addRole.Succeeded)
                    return Ok(await _service.CreateToken(user));
                return StatusCode(500, addRole.Errors);
            }
            return StatusCode(500, createdUser.Errors);
        }
    }
}
