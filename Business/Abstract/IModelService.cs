using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IModelService
    {
        List<Model> GetAll();
        List<Model> GetByCategory(int modelId);
        int add(Model modelId);
        int delete(Model modelId);
        int update(Model modelId);
        Model GetById(int modelId);
    }
}
