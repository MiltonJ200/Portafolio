using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
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
            var persona = new Persona()
            {
                Nombre = "Milton Josue Urbina",
                Edad = 22
            };
            //ViewBag.Nombre = "Milton Urbina";
            //ViewBag.Edad = 22;
            return View(persona); //return View("Index", persona); ya no es necesario colocar el index porque no nos vemos obligados a solicitarlo porque no tenemos nada en el mas que persona
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