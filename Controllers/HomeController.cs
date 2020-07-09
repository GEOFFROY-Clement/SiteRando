using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SiteRando.Data;
using SiteRando.Models;

namespace SiteRando.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context _context;

        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {


            DbSet<Hike> hikes = _context.Hikes;
            ViewBag.hikes = hikes;
            return View();
        }

        public IActionResult Privacy()
        {

            //Hike hike = new Hike("test", 10, 50, 20, 3, "totot", "tata", "je fais ce que je veux", "Marseille");
            //_context.Add(hike);
            //_context.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
