using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kusys.Entity
{
    public class Student
    {

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentLastname { get; set; }
        public string StudentBirthday { get; set; }

        //navigation property
        // her öğrenci bir tane ders seçebilir

        public string CourseId { get; set; }
        public Course Course { get; set; }
    }
}