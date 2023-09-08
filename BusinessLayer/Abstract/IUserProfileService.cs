using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserProfileService
    {
        List<userprofile> GetAllUserProfiles();
        userprofile GetUserProfileById(int id);
        userprofile CreateUserProfile(userprofile userprofile);
        userprofile UpdateUserProfile(userprofile userprofile);
        void DeleteUserProfile(int id);
    }
}
