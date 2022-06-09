using Kusys.Entity;
using Microsoft.EntityFrameworkCore;

namespace Kusys.Data
{
    public class CourseDbContext : DbContext
    {
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Student>? Students { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-MTU4EKB\\SQLEXPRESS;Database=Kusys_Demo;Trusted_Connection=true;");
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            Course[] courses = new Course[4]

                {
                 new Course() {CourseId="CSI101",CourseName="Introduction to Computer Science"},
                 new Course() {CourseId="CSI102",CourseName="Algorithms"},
                 new Course() {CourseId="MAT101",CourseName="Calculus"},
                 new Course() {CourseId="PHY101",CourseName="Physics"}
                };

            Student[] student = new Student[4]
                {
                 new Student() {StudentId=1,StudentName="Ayse",StudentLastname="Naz",StudentBirthday="2002-05-05",CourseId="CSI101"},
                 new Student() {StudentId=2,StudentName="Merve",StudentLastname="Usul",StudentBirthday="2002-06-05",CourseId="CSI102"},
                 new Student() {StudentId=3,StudentName="Can",StudentLastname="Zeki",StudentBirthday="2002-07-05",CourseId="MAT101"},
                 new Student() {StudentId=4,StudentName="Ali",StudentLastname="Daglı",StudentBirthday="2002-08-05",CourseId="PHY101"}
                };

            modelBuilder.Entity<Course>().HasData(courses);
            modelBuilder.Entity<Student>().HasData(student);

        }
    }
}