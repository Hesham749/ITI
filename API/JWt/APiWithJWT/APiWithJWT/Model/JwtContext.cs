using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APiWithJWT.Model
{
    public class JwtContext : IdentityDbContext
    {
        public JwtContext(DbContextOptions options)
            : base(options)
        {

        }
    }
}
