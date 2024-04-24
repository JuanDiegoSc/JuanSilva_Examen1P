using JuanSilva_Examen1P.Data;
using JuanSilva_Examen1P.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace JuanSilva_Examen1P.Controllers
{
    public class JS_HomeController : Controller
    {
        private readonly JuanSilva_Examen1PContext _context;

        public JS_HomeController(JuanSilva_Examen1PContext context)
        {
            _context = context;
        }

        public IActionResult JS_Index()
        {
            return View();
        }

        public IActionResult JS_Privacy()
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
