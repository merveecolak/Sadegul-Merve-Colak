using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusApp.Bussines.Abstract
{
    public interface IRepositoryService<T> 
    {
        List<T> GetAll();
        T GetById(T Entity);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
