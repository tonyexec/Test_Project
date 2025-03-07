using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Test_Project.Models;

namespace Test_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult SubMitForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SubMitForm(string InputValue)
        {
            return RedirectToAction("DisplayValue", new { value = InputValue});
        }
        public IActionResult DisplayValue(string value)
        {
            ViewData["UserInput"] = value;
            return View();
        }
        public IActionResult Index()
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
