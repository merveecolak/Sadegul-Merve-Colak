using Kusys.Data.Abstract;
using Kusys.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kusys.Data.Concrete
{
    public class EfCoreCourseRepository : EfCoreGenericRepository<Course,CourseDbContext>, ICourseRepository
    {
    }
}
