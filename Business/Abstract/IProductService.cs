using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
        int add(Product CarId);
        int delete(Product CarId);
        int update(Product CarId);
        Product GetById(int CarId);

        List<Product> ListWithCategory();
    }
}
