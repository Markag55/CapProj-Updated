using CapProj_Updated_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CapProj_Updated_.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Animation()
        {
            return View();
        }
        public IActionResult Comedy()
        {
            return View();
        }

        public IActionResult Drama()
        {
            return View();
        }

        public IActionResult Horror()
        {
            return View();
        }

        public IActionResult Romance()
        {
            return View();
        }

        public IActionResult SciFi()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

    }
}
