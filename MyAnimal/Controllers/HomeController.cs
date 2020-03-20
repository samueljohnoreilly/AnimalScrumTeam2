using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyAnimal.Models;

namespace MyAnimal.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult Mating() {
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [HttpGet]
        public IActionResult Communications() {
	        return View();
        }

        public IActionResult Habitat()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult PopCulture() {
	        return View();
        }

        public IActionResult Diet()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Behaviour() {
	        return View();
        }

        [HttpGet]
        public IActionResult About() {
            return View();
        }
    }
}
