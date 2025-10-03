using Microsoft.EntityFrameworkCore;
using StudentManagement_Obg.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement_Obg.Db
{
    public class StudentManagementDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StudentManagementDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(e =>
            {
                e.Property(s => s.FirstName).HasColumnType("nvarchar(50)");
                e.Property(s => s.MiddleName).HasColumnType("nvarchar(50)");
                e.Property(s => s.LastName).HasColumnType("nvarchar(50)");
                e.Property(s => s.Email).HasColumnType("nvarchar(100)");

                e.HasIndex(s => s.Email).IsUnique();
            });

            modelBuilder.Entity<Course>(e =>
            {
                e.Property(c => c.Title).HasColumnType("nvarchar(100)");
                e.HasOne<Instructor>().WithMany().HasForeignKey(c => c.InstructorId);
            });

            modelBuilder.Entity<Enrollment>(e =>
            {
                e.HasOne<Student>().WithMany().HasForeignKey(e => e.StudentId);
                e.HasOne<Course>().WithMany().HasForeignKey(e => e.CourseId);

                e.HasIndex(e => new { e.StudentId, e.CourseId }).IsUnique();
            });

            modelBuilder.Entity<Instructor>(e =>
            {
                e.Property(i => i.FirstName).HasColumnType("nvarchar(50)");
                e.Property(i => i.LastName).HasColumnType("nvarchar(50)");
                e.Property(i => i.Email).HasColumnType("nvarchar(100)");

                e.HasIndex(i => i.Email).IsUnique();
            });

            modelBuilder.Entity<Department>(e =>
            {
                e.Property(d => d.Name).HasColumnType("nvarchar(50)");
                e.HasOne<Instructor>().WithMany().HasForeignKey(d => d.DepartmentHeadId);

                e.HasIndex(d => d.DepartmentHeadId).IsUnique();
            });

            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Instructor>().ToTable("Instructor");
            modelBuilder.Entity<Department>().ToTable("Department");
        }

        public DbSet<Student> Students => Set<Student>();
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Enrollment> Enrollments => Set<Enrollment>();
        public DbSet<Instructor> Instructors => Set<Instructor>();
        public DbSet<Department> Departments => Set<Department>();
    }
}
