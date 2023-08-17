using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public user CreateUser(user user)
        {
            _userRepository.CreateUser(user);
            return user;
        }

        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }

        public List<user> GetAllUser()
        {
            return _userRepository.GetAllUsers();
        }

        public user GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public user UpdateUser(user user)
        {
            return _userRepository.UpdateUser(user);
        }
    }
}
