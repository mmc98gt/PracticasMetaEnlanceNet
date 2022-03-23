
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace PracticasMetaEnlance.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Medicos()
        {
            var medicos = new List<string>{"Pepe Sanchez", "Aurora Verde", "Paco Lopez"};
            ViewData["Medicos"] = medicos;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {

        }
    }
}
