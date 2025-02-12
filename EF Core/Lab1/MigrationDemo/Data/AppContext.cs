using Microsoft.EntityFrameworkCore;
using MigrationDemo.Models;

namespace MigrationDemo.Data
{
    internal partial class ClsAppContext : DbContext
    {

        public DbSet<ClsStudent> ClsStudents { get; set; }
        public DbSet<ClsDepartment> ClsDepartments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TestMigration;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }


    }
}
