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
    public class UserMan : IUserService
    {
        IUserDal _userDal;

        public UserMan(IUserDal userDal)
        {
          this._userDal = userDal;
        }

        public int add(User u)
        {
          return  _userDal.add(u);
        }

        public int delete(User UserId)
        {
            return _userDal.delete(UserId); 
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public List<User> GetByCategory(int UserId)
        {
            throw new NotImplementedException();
        }

        public User GetById(int UserId)
        {
            return _userDal.GetById(UserId);
        }

        public int update(User u)
        {
            return _userDal.update(u);
        }
    }
}
