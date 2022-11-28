using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        AContext c = new AContext();
        DbSet<T> o;

        public Repository()
        {
            o = c.Set<T>();
        }
        public int add(T entity)
        {
            o.Add(entity);
            return c.SaveChanges();
        }

        public int delete(T entity)
        {
            o.Remove(entity);
            return c.SaveChanges();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return o.ToList<T>();
        }

        public T GetById(int id)
        {
            return o.Find(id);
        }

        public int update(T entity)
        {
            o.Update(entity);
            return c.SaveChanges();
        }
    }
}
