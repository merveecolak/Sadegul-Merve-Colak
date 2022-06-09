using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kusys.Entity
{
    public class Course
    {

        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public List<Student> Students { get; set; }

    }
}
