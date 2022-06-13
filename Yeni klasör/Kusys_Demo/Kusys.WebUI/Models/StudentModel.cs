using Kusys.Entity;

namespace Kusys.WebUI.Models
{
    public class StudentModel
    {
        public List<Course> Courses { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentLastname { get; set; }
        public string StudentBirthday { get; set; }
    }
}
