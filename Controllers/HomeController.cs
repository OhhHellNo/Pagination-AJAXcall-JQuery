using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using pagination.Models;

namespace pagination.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }




    }
}
