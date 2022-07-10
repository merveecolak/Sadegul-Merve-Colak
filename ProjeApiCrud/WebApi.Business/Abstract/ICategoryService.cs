using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entity;

namespace WebApi.Business.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int id);
        List<Category> GetAll();
        Category Create(Category entity);
        Category Update(Category entity);
        void Delete(Category entity);
    }
}
