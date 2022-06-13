using Kusys.Business.Abstract;
using Kusys.Data.Abstract;
using Kusys.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kusys.Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private ICourseRepository _courseRepository;
        public CourseManager(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public void Create(Course entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Course entity)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {
            return _courseRepository.GetAll();

        }

        public Course GetById(string id)
        {
            return _courseRepository.GetById(id);
        }

        public void Update(Course entity)
        {
            throw new NotImplementedException();
        }
    }
}
