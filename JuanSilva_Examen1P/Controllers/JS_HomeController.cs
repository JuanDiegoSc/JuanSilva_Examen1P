using JuanSilva_Examen1P.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JuanSilva_Examen1P.Controllers
{
    public class JS_HomeController : Controller
    {
        private readonly ILogger<JS_HomeController> _logger;

        public JS_HomeController(ILogger<JS_HomeController> logger)
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
