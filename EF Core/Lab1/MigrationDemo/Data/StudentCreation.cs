using Microsoft.EntityFrameworkCore;
using MigrationDemo.Models;

namespace MigrationDemo.Data
{
    internal partial class ClsAppContext
    {
        partial void StudentCreation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClsStudent>(s =>
            {
                s.ToTable("Student");
                s.HasKey(a => a.Id);
                s.Property(a => a.Id).ValueGeneratedNever();
                s.Property(a => a.Name).HasMaxLength(20).IsRequired();
                s.HasAlternateKey(s => s.Name);

            });
        }
    }
}
