using KUSYS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS.Data.Abstract
{
    public interface ICourseRepository :IRepository<Course>
    {
        //Dersleri id ile alıp listeleyeceğim
        Course GetByIdWithCourses(int id);
    }
}
