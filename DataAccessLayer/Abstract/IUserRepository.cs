using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IUserRepository
    {
        List<user> GetAllUsers();
        user GetUserById(int id);
        user CreateUser (user user);
        user UpdateUser (user user);
        void DeleteUser (int id);
    }
}
