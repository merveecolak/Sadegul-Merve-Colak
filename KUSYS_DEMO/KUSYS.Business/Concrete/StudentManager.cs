using KUSYS.Business.Abstract;
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
