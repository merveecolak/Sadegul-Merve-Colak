using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ders_Secim_App.Models.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseTeacher { get; set; }
        public sbyte Credit { get; set; }
        public sbyte Preiod { get; set; }
        public List<CourseStudent> CourseStudents { get; set; }

    }
}
