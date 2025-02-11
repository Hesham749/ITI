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

        partial void StudentCreation(ModelBuilder modelBuilder);
        partial void DepartmentCreation(ModelBuilder modelBuilder);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            StudentCreation(modelBuilder);
            DepartmentCreation(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }


    }
}
