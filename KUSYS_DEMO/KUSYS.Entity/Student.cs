using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS.Entity
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? BirthDate { get; set; }

        //ilişki
        
        public Course? Course { get; set; }
        public List<StudentCourse>? StudentCourses { get; set; }
    }
}
