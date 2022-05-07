using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ders_Secim_App.Models.Entities
{
    public class CourseStudent
    {
        public int CourseStudentId { get; set; }
        public Course Courses { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student Student { get; set; }

    }
}
