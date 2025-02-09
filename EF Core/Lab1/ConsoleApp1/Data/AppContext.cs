using System;
using System.Collections.Generic;
using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1;

public partial class AppContext : DbContext
{
    public AppContext()
    {
    }

    public AppContext(DbContextOptions<AppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Dependent> Dependents { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<WorksFor> WorksFors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=.; database = company_sd ; integrated security = true ; trust server certificate = true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Dnum);

            entity.Property(e => e.Dnum).ValueGeneratedNever();
            entity.Property(e => e.Dname).HasMaxLength(50);
            entity.Property(e => e.Mgrssn).HasColumnName("MGRSSN");
            entity.Property(e => e.MgrstartDate)
                .HasColumnType("datetime")
                .HasColumnName("MGRStart Date");

            entity.HasOne(d => d.MgrssnNavigation).WithMany(p => p.Departments)
                .HasForeignKey(d => d.Mgrssn)
                .HasConstraintName("FK_Departments_Employee");
        });

        modelBuilder.Entity<Dependent>(entity =>
        {
            entity.HasKey(e => new { e.Essn, e.DependentName });

            entity.ToTable("Dependent");

            entity.Property(e => e.Essn).HasColumnName("ESSN");
            entity.Property(e => e.DependentName)
                .HasMaxLength(255)
                .HasColumnName("Dependent_name");
            entity.Property(e => e.Bdate).HasColumnType("datetime");
            entity.Property(e => e.Sex).HasMaxLength(255);

            entity.HasOne(d => d.EssnNavigation).WithMany(p => p.Dependents)
                .HasForeignKey(d => d.Essn)
                .HasConstraintName("FK_Dependent_Employee");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Ssn);

            entity.ToTable("Employee");

            entity.Property(e => e.Ssn)
                .ValueGeneratedNever()
                .HasColumnName("SSN");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Bdate).HasColumnType("datetime");
            entity.Property(e => e.Fname).HasMaxLength(50);
            entity.Property(e => e.Lname).HasMaxLength(50);
            entity.Property(e => e.Sex).HasMaxLength(50);

            entity.HasOne(d => d.DnoNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.Dno)
                .HasConstraintName("FK_Employee_Departments");

            entity.HasOne(d => d.SuperssnNavigation).WithMany(p => p.InverseSuperssnNavigation)
                .HasForeignKey(d => d.Superssn)
                .HasConstraintName("FK_Employee_Employee");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Pnumber);

            entity.ToTable("Project");

            entity.Property(e => e.Pnumber).ValueGeneratedNever();
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Plocation).HasMaxLength(50);
            entity.Property(e => e.Pname).HasMaxLength(50);

            entity.HasOne(d => d.DnumNavigation).WithMany(p => p.Projects)
                .HasForeignKey(d => d.Dnum)
                .HasConstraintName("FK_Project_Departments");
        });

        modelBuilder.Entity<WorksFor>(entity =>
        {
            entity.HasKey(e => new { e.Essn, e.Pno });

            entity.ToTable("Works_for");

            entity.Property(e => e.Essn).HasColumnName("ESSn");

            entity.HasOne(d => d.EssnNavigation).WithMany(p => p.WorksFors)
                .HasForeignKey(d => d.Essn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Works_for_Employee");

            entity.HasOne(d => d.PnoNavigation).WithMany(p => p.WorksFors)
                .HasForeignKey(d => d.Pno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Works_for_Project");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
