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
    public class UserProfileService : IUserProfileService
    {
        IUserProfileRepository _UserProfileRepository;
        public UserProfileService(IUserProfileRepository userProfileRepository)
        {
            _UserProfileRepository = userProfileRepository;
        }
        public userprofile CreateUserProfile(userprofile userprofile)
        {
            _UserProfileRepository.CreateUserProfile(userprofile);
            return userprofile;
        }

        public void DeleteUserProfile(int id)
        {
            _UserProfileRepository.DeleteUserProfile(id);
        }

        public List<userprofile> GetAllUserProfiles()
        {
            return _UserProfileRepository.GetAllUserProfiles();
        }

        public userprofile GetUserProfileById(int id)
        {
            return _UserProfileRepository.GetUserProfileById(id);
        }

        public userprofile UpdateUserProfile(userprofile userprofile)
        {
            return _UserProfileRepository.UpdateUserProfile(userprofile);
        }
    }
}
