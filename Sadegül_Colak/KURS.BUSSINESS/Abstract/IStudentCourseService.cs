using KURS.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURS.BUSSINESS.Abstract
{
    public interface IStudentCourseService
    {
        StudentCourse GetById(int id);
        List<StudentCourse> GetAll();
        void Create(StudentCourse entity);
        void Update(StudentCourse entity);
        void Delete(StudentCourse entity);
    }
}
