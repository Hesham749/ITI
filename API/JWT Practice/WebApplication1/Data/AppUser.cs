using System;
using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Data;

public class AppUser:IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
}
