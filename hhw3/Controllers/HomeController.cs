using hhw3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace hhw3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Rev(string Name)
        {
            var r = new string(Name.Reverse().ToArray());
            ViewData["n"] = r;
            return View("Index");
        }

      
    }
}