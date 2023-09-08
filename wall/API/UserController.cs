using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace wall.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userservice;

        public UserController(IUserService userservice)
        {
            _userservice = userservice;
        }

        [HttpGet]
        public List<user> Get()
        {
            return _userservice.GetAllUser();
        }
        [HttpGet("{id}")]
        public user Get(int id)
        {
            return _userservice.GetUserById(id);
        }

        [HttpPost]
        public user Post([FromBody] user user)
        {
            return _userservice.CreateUser(user);
        }
        [HttpPut]
        public user Put([FromBody] user user)
        {
            return _userservice.UpdateUser(user);
        }

    }
}
