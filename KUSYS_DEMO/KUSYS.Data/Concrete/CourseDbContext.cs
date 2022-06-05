using KUSYS.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS.Data.Concrete
{
    public class CourseDbContext :DbContext
    {

        public DbSet<Student>? Students { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<StudentCourse>? StudentCourses { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = CourseDb");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>().HasKey(x => x.StudentCourseId);
            modelBuilder.Entity<Course>().HasKey(x => x.CourseId);
            modelBuilder.Entity<Student>().HasKey(x => x.StudentId);

        }
    }
}

