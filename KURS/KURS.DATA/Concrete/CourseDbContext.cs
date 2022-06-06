using KURS.ENTITY;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURS.DATA.Concrete
{
    public class CourseDbContext : DbContext
    {
        public DbSet<Student>? Students { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<StudentCourse>? StudentCourses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source = KursDb.db ");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Course[] courses = new Course[4]
            {
                new Course() {CourseId=1,CourseCode="CSI101",Name="Introduction to Computer Science"},
                new Course() {CourseId=2,CourseCode="CSI102",Name="Algorithms"},
                new Course() {CourseId=3,CourseCode="MAT101",Name="Calculus"},
                new Course() {CourseId=4,CourseCode="PHY101",Name="Physics"}
            };

            Student[] student = new Student[4]
            {
                new Student() {StudentId=1,FirstName="Ayse",LastName="Naz"},
                new Student() {StudentId=2,FirstName="Merve",LastName="Usul"},
                new Student() {StudentId=3,FirstName="Can",LastName="Zeki"},
                new Student() {StudentId=4,FirstName="Ali",LastName="Daglı"}
            };

            modelBuilder.Entity<Course>().HasData(courses); 

        }
    }
}
