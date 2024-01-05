using DewJUnit1MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DewJUnit1MVC.Controllers
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

        public IActionResult Output(Customer model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.CU = model.DetermineEmail();
                ViewBag.Name = model.Name;
                ViewBag.title = "Thank You";
            }
            else
            {
                ViewBag.CU = "N/A";
                ViewBag.Name = "visitor";
                ViewBag.title = "*extremely loud incorrect buzzer*";
            }
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
