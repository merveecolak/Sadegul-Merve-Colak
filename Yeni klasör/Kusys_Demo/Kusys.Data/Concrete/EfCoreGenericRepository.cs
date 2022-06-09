using Kusys.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kusys.Data.Concrete
{
    public  class EfCoreGenericRepository<TEntity, TContext> : IRepository<TEntity> where TEntity : class
        where TContext : CourseDbContext, new()
    {

        public void Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            using (var context = new CourseDbContext())
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll()
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public TEntity GetById(int id)
        {
            using (var context=new CourseDbContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
