using KUSYS.Data.Abstract;
using KUSYS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS.Data.Concrete.EfCore
{
    public class EfCoreStudentRepository : EfCoreGenericRepository<Student,CourseDbContext>,IStudentRepository
    {
    }
}
