using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigrationDemo.Models;

namespace MigrationDemo.Data
{
    internal partial class ClsAppContext : IEntityTypeConfiguration<ClsDepartment>
    {
        public void Configure(EntityTypeBuilder<ClsDepartment> builder)
        {
            builder.ToTable("Department");
            builder.HasKey(a => a.Id);
            builder.Property(d => d.DeptName).HasMaxLength(20).IsRequired();
            builder.HasMany(d => d.Students)
            .WithOne(s => s.Department)
            .HasForeignKey(s => s.DeptId)
            .IsRequired().OnDelete(DeleteBehavior.NoAction);
        }
    }
}
