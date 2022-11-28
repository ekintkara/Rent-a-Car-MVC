using DataAccess.Abstract;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ProductDal :Repository<Product>,IProductDal
    {

        public List<Product> ListWithCategory()
        {
            using(var AContext = new AContext())
            {
                return AContext.products.Include(x => x.Categories).ToList();
            }
        }
    }
}
