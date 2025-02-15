using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.Model.ModelConfig
{
    partial class Context : IEntityTypeConfiguration<ClsDepartment>
    {
        public void Configure(EntityTypeBuilder<ClsDepartment> builder)
        {
            builder.HasMany(d => d.Employees)
                .WithOne(e => e.Department)
                .HasForeignKey(e => e.DeptId)
                .IsRequired();

            builder.HasMany(d => d.Supers)
                .WithOne(e => e.MangedDepartment);

        }
    }
}
