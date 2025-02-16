// Ignore Spelling: Crs

using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public partial class Context : DbContext
    {
        public Context()
            : base()
        {

        }
        public DbSet<ClsCourse> ClsCourses { get; set; }
        public DbSet<ClsCrsResult> ClsCrsResults { get; set; }
        public DbSet<ClsDepartment> ClsDepartments { get; set; }
        public DbSet<ClsInstructor> ClsInstructors { get; set; }
        public DbSet<ClsTrainee> ClsTrainees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MvcITI;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
