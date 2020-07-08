using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SiteRando.Models;

namespace SiteRando.Controllers
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
            Hike rando = new Hike(1, "Rando de test", 1000, 280, 120, 2, "nous commençons sur la place de la mairie", "nous finissons au bar du coin", "a boire a boire a boire", "Thonon les bains");
            Hike rando1 = new Hike(2, "Rando préférée", 1000, 280, 120, 2, "nous commençons sur la place de la mairie", "nous finissons au bar du coin", "a boire a boire a boire", "Thonon les bains");
            Hike rando2 = new Hike(3, "Rando que je deteste", 1000, 280, 120, 2, "nous commençons sur la place de la mairie", "nous finissons au bar du coin", "a boire a boire a boire", "Thonon les bains");
            ViewBag.hike = rando;
            ViewBag.hike1 = rando1;
            ViewBag.hike2 = rando2;
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
