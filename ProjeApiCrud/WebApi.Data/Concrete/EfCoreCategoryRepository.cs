using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Data.Abstarct;
using WebApi.Entity;

namespace WebApi.Data.Concrete
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, WebApiContext>, ICategoryRepository
    {
    }
}
