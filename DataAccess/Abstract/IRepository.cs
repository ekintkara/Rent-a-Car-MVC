using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepository<T>
    {
        public int add(T entity);
        public int update(T entity);
        public int delete(T entity);
        public List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T GetById(int id);

    }
}
