using Kusys.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kusys.Business.Abstract
{
    public interface ICourseService
    {
        Course GetById(int id);
        List<Course> GetAll();
        void Create(Course entity);
        void Update(Course entity);
        void Delete(Course entity);
    }
}
