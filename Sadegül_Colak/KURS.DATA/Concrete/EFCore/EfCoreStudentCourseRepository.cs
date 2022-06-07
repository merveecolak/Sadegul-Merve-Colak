using KURS.DATA.Abstract;
using KURS.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURS.DATA.Concrete.EFCore
{
    public class EfCoreStudentCourseRepository : EfCoreGenericRepository<StudentCourse,CourseDbContext> , IStudentCourseRepository
    {
    }
}
