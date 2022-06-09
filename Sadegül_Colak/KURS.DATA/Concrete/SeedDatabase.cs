//using KURS.DATA.Concrete;
//using KURS.ENTITY;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace KUSYS_Project.Data.Concrete
//{
//    public class SeedDatabase
//    {
//        //public static void Seed()
//        //{
//        //    var context = new CourseDbContext();
//        //    if (context.Database.GetPendingMigrations().Count() == 0)
//        //    {
//        //        if (context.Courses == null || context.Courses.Count() == 0)
//        //        {


//        //        }
//        //       else if (context.Courses != null)
//        //        {
//        //            context.Courses.AddRange(Courses);
//        //        }
//        //    }
//        //    context.SaveChanges();
//        //}
//        private static Course[] Courses =
//        {
//            new Course() {CourseCode="CSI101",Name="Introduction to Computer Science"},
//            new Course() {CourseCode="CSI102",Name="Algorithms"},
//            new Course() {CourseCode="MAT101",Name="Calculus"},
//            new Course() {CourseCode="PHY101",Name="Physics"}
//        };

//        private static Student[] student = 
//           {
//                new Student() {StudentId=1,FirstName="Ayse",LastName="Naz"},
//                new Student() {StudentId=2,FirstName="Merve",LastName="Usul"},
//                new Student() {StudentId=3,FirstName="Can",LastName="Zeki"},
//                new Student() {StudentId=4,FirstName="Ali",LastName="Daglı"}
//           };

//    }
//}
