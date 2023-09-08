using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using wall.Models;

namespace wall.Controllers
{
    public class HomeController : Controller
    {
        private IUserService _userService;
        private IPostService _postService;
        private IUserProfileService _userprofileService;
        public wallPost wallPost = new wallPost();
        private wallContext _wallContext;
        public HomeController(wallContext wallContext, IUserService userService, IPostService postService, IUserProfileService userProfileService)
        {
            _wallContext = wallContext; 
            _userService = userService;
            _postService = postService;
            _userprofileService = userProfileService;
        }


        public IActionResult Index()
        {
            wallPost.userprofiles = _userprofileService.GetAllUserProfiles();
            wallPost.posts = _postService.GetAllPosts();
            return View(wallPost);
        }
    }
}