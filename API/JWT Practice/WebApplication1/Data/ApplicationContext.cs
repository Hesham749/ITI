using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data;

public class ApplicationContext : IdentityDbContext<AppUser>
{
    public ApplicationContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        var roles = new List<IdentityRole>
        {
            new ()
            {
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new()
            {
                 Name = "User",
                NormalizedName = "USER"
            }
        };
        builder.Entity<IdentityRole>().HasData(roles);

    }
}
