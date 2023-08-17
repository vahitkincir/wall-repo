using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        List<user> GetAllUser();
        user GetUserById(int id);
        user CreateUser (user user);
        user UpdateUser (user user);
        void DeleteUser (int id);
    }
}
