using KURS.BUSSINESS.Abstract;
using KURS.DATA.Abstract;
using KURS.DATA.Concrete;
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
        private CourseDbContext _context;
        public StudentManager(CourseDbContext context)
        {
            _context = context;
        }

        public void Create(Student entity)
        {
            _context.Students.Add(entity);
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
            return _context.Students.ToList();
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
