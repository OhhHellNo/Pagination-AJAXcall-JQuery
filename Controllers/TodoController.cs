using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using pagination.Models;

namespace pagination.Controllers
{
    public class TodoController : Controller
    {

        public IActionResult Create()
        {
            return View();
        }


        public IActionResult Update()
        {
            return View();
        }


        public IActionResult GetTodos()
        {
            return View();
        }


        public IActionResult DeleteTodos()
        {
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }

    }


}