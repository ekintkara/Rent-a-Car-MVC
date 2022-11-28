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
    public class ModelMan : IModelService
    {
        IModelDal modelDal;

        public ModelMan(IModelDal modelDal)
        {
            this.modelDal = modelDal;
        }

        public int add(Model modelId)
        {
            return modelDal.add(modelId);
        }

        public int delete(Model modelId)
        {
            return modelDal.delete(modelId);
        }

        public List<Model> GetAll()
        {
            return modelDal.GetAll();
        }

        public List<Model> GetByCategory(int modelId)
        {
            throw new NotImplementedException();
        }

        public Model GetById(int modelId)
        {
            return modelDal.GetById(modelId);
        }

        public int update(Model modelId)
        {
            return modelDal.update(modelId);
        }
    }
}
