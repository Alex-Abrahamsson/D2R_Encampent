using D2R_Encampent.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace D2R_Encampent.Controllers
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
        public IActionResult Basics()
        {
            return View();
        }
        public IActionResult Classes()
        {
            return View();
        }
        public IActionResult Skills()
        {
            return View();
        }
        public IActionResult Items()
        {
            return View();
        }
        public IActionResult Monsters()
        {
            return View();
        }
        public IActionResult Npcs()
        {
            return View();
        }
        public IActionResult Quests()
        {
            return View();
        }
        public IActionResult Shrines()
        {
            return View();
        }
        public IActionResult Maps()
        {
            return View();
        }
        public IActionResult Faq()
        {
            return View();
        }
        public IActionResult Files()
        {
            return View();
        }
        public IActionResult SkillInfo()
        {
            return View();
        }
        public IActionResult CastInfo()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}