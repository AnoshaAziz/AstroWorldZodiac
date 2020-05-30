using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AstroWorldZodiac.Models;

namespace AstroWorldZodiac.Controllers
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
        public IActionResult Signup()
        {
            return View();
        }
        public IActionResult Signin()
        {
            return View();
        }

        public IActionResult Zodiacs()
        {
            return View();
        }

        public IActionResult Gemestone()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Appointment()
        {
            return View();
        }
        public IActionResult Mantra()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Astrology()
        {
            return View();
        }
        public IActionResult Feedbacks()
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
