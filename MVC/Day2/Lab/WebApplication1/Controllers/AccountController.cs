using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace ITI.Controllers
{
    public class AccountController : Controller
    {
        private readonly ITIZagContext db;
        public AccountController(ITIZagContext context)
        {
            db = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = db.Users.Include(s => s.Roles).FirstOrDefault(s => s.Mail == model.Email && s.Password == model.Password);
                if (user == null)
                {
                    ModelState.AddModelError("", "Invalid username or password");
                    return View(model);
                }
                else
                {
                    // Create claims
                    var claims = new List<Claim>
                    {
                        new (ClaimTypes.Name, user.Name),
                        new (ClaimTypes.Email, user.Mail)
                    };

                    // Add role claims
                    foreach (var role in user.Roles)
                    {
                        claims.Add(new(ClaimTypes.Role, role.Name));
                    }

                    // Create identity
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    // Create principal
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                    // Sign in
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);

                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            // Sign out
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Home");
        }
        // register 
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            if (user.Roles == null)
            {
                user.Roles = new List<Role>();
            }

            Role r = db.Roles.FirstOrDefault(a => a.Id == 3);
            if (r != null)
            {
                user.Roles.Add(r);
            }

            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState.Values)
                {
                    foreach (var e in error.Errors)
                    {
                        Console.WriteLine(e.ErrorMessage);
                    }
                }
                return View(user);
            }

            db.Users.Add(user);
            await db.SaveChangesAsync();

            return RedirectToAction("Login", "Account");
        }

    }
}
