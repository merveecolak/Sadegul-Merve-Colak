using KURS.BUSSINESS.Abstract;
using KURS.DATA.Abstract;
using KURS.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURS.BUSSINESS.Concrete
{
    public class StudentCourseManager : IStudentCourseService
    {
        private readonly IStudentCourseRepository _studentCourseRepository;
        public StudentCourseManager(IStudentCourseRepository studentCourseRepository)
        {
            _studentCourseRepository=studentCourseRepository;
        }
        public void Create(StudentCourse entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(StudentCourse entity)
        {
            throw new NotImplementedException();
        }

        public List<StudentCourse> GetAll()
        {
            return _studentCourseRepository.GetAll();
        }

        public StudentCourse GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(StudentCourse entity)
        {
            throw new NotImplementedException();
        }
    }
}
