using KUSYS.Data.Abstract;
using KUSYS.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS.Data.Concrete.EfCore
{
    public class EfCoreStudentRepository : EfCoreGenericRepository<Student, CourseDbContext>, IStudentRepository
    {
        public Student GetByIdWithCourses(int id)
        {
            using (var context = new CourseDbContext())
            {
                return context.Students
                    .Where(i => i.StudentId == id)
                    .Include(i => i.StudentCourses)
                    .ThenInclude(i => i.Course)
                    .FirstOrDefault();
            }
        }

        public List<Student> GetHomePageProducts()
        {
            using (var context = new CourseDbContext())
            {
                return context
                    .Students
                    .ToList();
            }
        }
    }
}
