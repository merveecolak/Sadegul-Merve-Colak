using KUSYS.Business.Abstract;
using KUSYS.Data.Abstract;
using KUSYS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private IStudentRepository _studentRepository;
        public StudentManager(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public bool Create(Student entity, int[] courseIds)
        {
            throw new NotImplementedException();
        }

        public void Delete(Student entity)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
           return _studentRepository.GetAll().ToList();
        }

        public Student GetByIdWithCourses(int id)
        {
            return _studentRepository.GetByIdWithCourses(id);
        }

        public List<Student> GetHomePageProducts()
        {
            throw new NotImplementedException();
        }

        public void Update(Student entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Student entity, int[] courseIds)
        {
            throw new NotImplementedException();
        }
    }
}
