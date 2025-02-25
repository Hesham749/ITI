using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Core.Models;

namespace RepositoryPattern.EF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
