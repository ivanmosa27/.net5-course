using course_net_core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using course_net_core.Models;

namespace course_net_core.Controllers
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
        [HttpPost]
        public IActionResult add()
        {
            int num1 = Convert.ToInt32(HttpContext.Request.Form["num1"].ToString());
            int num2 = Convert.ToInt32(HttpContext.Request.Form["num2"].ToString());
            int result = num1 + num2;
            ViewBag.SumResult = result.ToString();
            return View("Sumar");
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Sumar()
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
