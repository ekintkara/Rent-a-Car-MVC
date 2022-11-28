using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryMan : ICategoryService
    {
        ICategoryDal _categorydal;

        public CategoryMan(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public int add(Category categoryId)
        {
            return _categorydal.add(categoryId);
        }

        public int delete(Category categoryId)
        {
            return _categorydal.delete(categoryId);
        }

        public List<Category> GetAll()
        {
            return _categorydal.GetAll();
        }

        public List<Category> GetByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int categoryId)
        {
            return _categorydal.GetById(categoryId);
        }

        public int update(Category categoryId)
        {
            return _categorydal.update(categoryId);
        }
    }
}
