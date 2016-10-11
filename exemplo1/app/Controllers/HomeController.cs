using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        IConfigurationRoot _configuration;

        public HomeController (IConfigurationRoot configuration)
        {   
            _configuration =configuration;
        }   

        public IActionResult Index()
        {
             ViewData["Message"] = _configuration["MESSAGE"];
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Information";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
