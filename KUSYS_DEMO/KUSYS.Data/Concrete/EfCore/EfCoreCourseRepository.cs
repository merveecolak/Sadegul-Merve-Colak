using KUSYS.Data.Abstract;
using KUSYS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS.Data.Concrete.EfCore
{
    public class EfCoreCourseRepository : EfCoreGenericRepository<Course, CourseDbContext>, ICourseRepository
    {
        public Course GetByIdWithCourses(string id)
        {
            using (var context=new CourseDbContext())
            {
                return context.Courses.Where(i=>i.CourseId==id)
                    .Include(i=>i.)
            }
        }
    }
}
