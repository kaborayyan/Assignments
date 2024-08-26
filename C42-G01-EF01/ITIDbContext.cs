using C42_G01_EF01.Configuration;
using C42_G01_EF01.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF01
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = ITI_DB; Trusted_Connection = True; TrustServerCertificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new InstructorConfiguration());
            modelBuilder.ApplyConfiguration(new TopicConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());

            #region Relations
            // Relations
            // One to many
            // Student Department
            modelBuilder.Entity<Department>()
                        .HasMany(D => D.Students)
                        .WithOne(S => S.Department)
                        .HasForeignKey(S => S.DepartmentID);
            //================================================

            // Many to Many
            // Student Course StudentCourse            
            // First if needed add a Composite Key
            modelBuilder.Entity<StudentCourse>()
                        .HasKey(SC => new { SC.StudentID, SC.CourseID });

            // Second link the third table
            modelBuilder.Entity<Student>()
                        .HasMany(S => S.StudentCourses)
                        .WithOne(SC => SC.Student)
                        .IsRequired(true)
                        .HasForeignKey(SC => SC.StudentID);

            modelBuilder.Entity<Course>()
                        .HasMany(C => C.CourseStudents)
                        .WithOne(SC => SC.Course)
                        .IsRequired(true)
                        .HasForeignKey(SC => SC.CourseID);
            // ===============================================

            // One to many
            // Course Topic
            modelBuilder.Entity<Course>()
                        .HasMany(C => C.Topics)
                        .WithOne(T => T.Course)
                        .HasForeignKey(T => T.CourseID);
            // ===============================================

            // many to many Course Instructor
            // Composite Key
            modelBuilder.Entity<CourseInstructor>()
                        .HasKey(SC => new { SC.InstructorID, SC.CourseID });

            // Second link the third table
            modelBuilder.Entity<Instructor>()
                        .HasMany(I => I.InstructorCourses)
                        .WithOne(IC => IC.Instructor)
                        .IsRequired(true)
                        .HasForeignKey(IC => IC.InstructorID);

            modelBuilder.Entity<Course>()
                        .HasMany(C => C.CourseInstructors)
                        .WithOne(IC => IC.Course)
                        .IsRequired(true)
                        .HasForeignKey(IC => IC.CourseID);
            // =================================================
            // One to many
            // Instructor Department
            modelBuilder.Entity<Department>()
                        .HasMany(D => D.Instructors)
                        .WithOne(I => I.Department)
                        .HasForeignKey(I => I.DepartmentID);

            #endregion

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
    }
}
