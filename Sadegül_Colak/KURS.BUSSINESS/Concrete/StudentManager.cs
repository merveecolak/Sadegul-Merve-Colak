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
    public class StudentManager : IStudentService
    {
        private IStudentRepository _studentRepository;
        public StudentManager(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void Create(Student entity)
        {
            _studentRepository.Create(entity);
        }

       
        public void Delete(Student entity)
        {
            _studentRepository.Delete(entity);
        }

        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }

        public Student GetById(int id)
        {
            return _studentRepository.GetById(id);
        }

        public void Update(Student entity)
        {
            _studentRepository.Update(entity);
        }

       
    }
}
