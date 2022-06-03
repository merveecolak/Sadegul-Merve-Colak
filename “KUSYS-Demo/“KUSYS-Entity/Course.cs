using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _KUSYS_Entity
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? Name { get; set; }
        public string? CourseFakeId { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
    }
}
