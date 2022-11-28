using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {

        List<Category> GetAll();
        List<Category> GetByCategory(int categoryId);
        int add(Category categoryId);
        int delete(Category categoryId);
        int update(Category categoryId);
        Category GetById(int categoryId);
    }
}
