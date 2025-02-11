using Microsoft.EntityFrameworkCore;
using MigrationDemo.Models;

namespace MigrationDemo
{
    internal partial class AppContext
    {
        partial void DepartmentCreation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClsDepartment>(d =>
            {
                d.ToTable("Department");
                d.HasKey(a => a.Id);
                d.Property(d => d.DeptName).HasMaxLength(20).IsRequired();
                d.HasMany(d => d.Students)
                .WithOne(s => s.Department)
                .HasForeignKey(s => s.DeptId)
                .IsRequired().OnDelete(DeleteBehavior.NoAction);


            });
        }
    }
}
