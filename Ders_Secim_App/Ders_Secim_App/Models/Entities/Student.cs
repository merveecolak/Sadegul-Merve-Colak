using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ders_Secim_App.Models.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public int StudentNo { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public int DepartmentId { get; set; }
        public DateTime DateOfBirth  { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public sbyte Period { get; set; }


        public List<CourseStudent> CourseStudents { get; set; } // bir öğrencinin birden fazla dersi olabilir
        public Department Department { get; set; }
    }
}
