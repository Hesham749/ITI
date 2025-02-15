// Ignore Spelling: App

using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Model
{
    partial class Context : DbContext
    {
        public DbSet<ClsDepartment> ClsDepartments { get; set; }
        public DbSet<ClsEmployee> ClsEmployees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Lab3Migration;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
