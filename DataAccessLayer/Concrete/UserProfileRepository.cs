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
    public class UserProfileRepository : IUserProfileRepository
    {
        wallContext _wallContext;

        public UserProfileRepository(wallContext wallContext)
        {
            _wallContext = wallContext;
        }

        public userprofile CreateUserProfile(userprofile userprofile)
        {
            using (_wallContext)
            {
                _wallContext.userprofiles.Add(userprofile);
                _wallContext.SaveChanges();
                return userprofile;
            }
        }

        public void DeleteUserProfile(int id)
        {
            using (_wallContext)
            {
                var profile = _wallContext.userprofiles.Find(id);
                _wallContext.userprofiles.Remove(profile);
                _wallContext.SaveChanges();
            }
            
        }

        public List<userprofile> GetAllUserProfiles()
        {
            using (_wallContext)
            {
                return _wallContext.userprofiles.ToList();
            }
        }

        public userprofile GetUserProfileById(int id)
        {
            using (_wallContext)
            {
                var profile = _wallContext.userprofiles.Find(id);
                return profile;
            }
        }

        public userprofile UpdateUserProfile(userprofile userprofile)
        {
            using (_wallContext)
            {
                _wallContext.userprofiles.Update(userprofile);
                return userprofile;
            }
        }
    }
}
