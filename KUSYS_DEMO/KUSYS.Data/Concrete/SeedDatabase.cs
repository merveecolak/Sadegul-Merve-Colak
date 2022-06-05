using KUSYS.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS.Data.Concrete
{
    public class SeedDatabase
    {
        public static void Seed()
        {
            var context = new CourseDbContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Courses == null || context.Courses.Count() == 0)
                {
                    if (context.Courses != null)
                    {
                        context.Courses.AddRange(Courses);
                    }

                }
            }
            context.SaveChanges();
        }
        private static Course[] Courses =
        {
            new Course() {CourseCode="CSI101",CourseName="Introduction to Computer Science"},
            new Course() {CourseCode="CSI102",CourseName="Algorithms"},
            new Course() {CourseCode="MAT101",CourseName="Calculus"},
            new Course() {CourseCode="PHY101",CourseName="Physics"}
        };

        private static Student[] Student =
        {
            new Student() {FirstName="Ayse",LastName="Beril",BirthDate="2001-04-04"},
            new Student() {FirstName="Ali",LastName="Veli",BirthDate="2001-05-05"},
            new Student() {FirstName="Merve",LastName="Bilge",BirthDate="2001-06-06"},
            new Student() {FirstName="Can",LastName="Berk",BirthDate="2001-07-07"}
        };
    }
}
