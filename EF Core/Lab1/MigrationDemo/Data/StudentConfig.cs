using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigrationDemo.Models;

namespace MigrationDemo.Data
{
    internal partial class ClsAppContext : IEntityTypeConfiguration<ClsStudent>
    {
        public void Configure(EntityTypeBuilder<ClsStudent> builder)
        {
            builder.ToTable("Student");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedNever();
            builder.Property(a => a.Name).HasMaxLength(20).IsRequired();
            builder.HasAlternateKey(s => s.Name);
        }

    }
}
