using KUSYS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS.Data.Abstract
{
    public interface IStudentRepository : IRepository<Student>
    {
        List<Student> GetHomePageProducts();
        public Student GetByIdWithCourses(int id);
    }
}

