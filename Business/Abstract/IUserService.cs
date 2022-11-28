using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        List<User> GetByCategory(int UserId);
        int add(User u);
        int delete(User UserId);
        int update(User u);
        User GetById(int UserId);
    }
}
