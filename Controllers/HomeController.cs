using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RazorCalendar.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RazorCalendar.Controllers
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
            IList<Beze> lista = new List<Beze>();
            lista.Add(new Beze {
                Kolicina = 0,
                Datum = DateTime.Now
            });
            lista.Add(new Beze
            {
                Kolicina = 1,
                Datum = DateTime.Now.AddDays(1)
            });
            lista.Add(new Beze
            {
                Kolicina = -1,
                Datum = DateTime.Now.AddDays(-1)
            });
            lista.Add(new Beze
            {
                Kolicina = 100,
                Datum = DateTime.Now.AddMonths(1)
            });
            lista.Add(new Beze
            {
                Kolicina = -500,
                Datum = DateTime.Now.AddMonths(-1)
            });
            lista.Add(new Beze
            {
                Kolicina = 0,
                Datum = DateTime.Now.AddYears(1)
            });
            return View(lista);
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
