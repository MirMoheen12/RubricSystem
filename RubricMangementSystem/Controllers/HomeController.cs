using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RubricMangementSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RubricMangementSystem.Controllers
{
    //[Authorize(Roles ="Admin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Error_Page()
        {
            return View();
        }

       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
    
        public IActionResult test1()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

      
        public IActionResult Error()
        {
            return View();
        }
    }
}
