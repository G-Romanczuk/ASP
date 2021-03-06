using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using ASP.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int id)
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public string About()
        {
            return "Coś";
        }

        public string Hello(string name)
        {
            return $"Cześć {name}";
        }

        public IActionResult PowerForm()
        {
            return View();
        }

        public string Power(int? number)
        {
            if (number != null)
            {
                var wynik = (int)(number * number);
                return $"Liczba {number} podniesiona do kwadratu to: {wynik}";
            }
            else
                return "Należy podać liczbę";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
