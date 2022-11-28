using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductMan : IProductService
    {
        IProductDal _productDal;

        public ProductMan(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public int add(Product CarId)
        {
           return _productDal.add(CarId);
        }

        public int delete(Product CarId)
        {
            return _productDal.delete(CarId);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetByCategory(int CarId)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int CarId)
        {
            return _productDal.GetById(CarId);
        }

        public List<Product> ListWithCategory()
        {
            return _productDal.ListWithCategory();
        }

        public int update(Product CarId)
        {
            return _productDal.update(CarId);   
        }
    }
}
