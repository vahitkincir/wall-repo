using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{

    public class UserRepository : IUserRepository
    {
        wallContext _wallContext;
        public UserRepository(wallContext wallContext)
        {
            _wallContext = wallContext;
        }
        public user CreateUser(user user)
        {
            using (_wallContext)
            {
                _wallContext.users.Add(user);
                _wallContext.SaveChanges();
                return user;
            }
        }

        public void DeleteUser(int id)
        {
            using (_wallContext)
            {
                var user = _wallContext.users.Find(id);
                _wallContext.users.Remove(user);
                _wallContext.SaveChanges();
            }
        }

        public List<user> GetAllUsers()
        {
            using (_wallContext)
            {
                return _wallContext.users.ToList();
            }
            //return _wallContext.users.ToList();
        }

        public user GetUserById(int id)
        {
            using (_wallContext)
            {
                return _wallContext.users.Find(id);
            }
        }

        public user UpdateUser(user user)
        {
            using (_wallContext)
            {
                _wallContext.users.Update(user);
                _wallContext.SaveChanges();
                return user;

            }
        }
    }
}
