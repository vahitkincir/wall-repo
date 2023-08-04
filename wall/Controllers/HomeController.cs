using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using wall.Models;

namespace wall.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}