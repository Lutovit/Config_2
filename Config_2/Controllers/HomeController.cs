using Config_2.Models;
using Config_2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Config_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IAdminConfigService _adminService;
        
        
        public HomeController(ILogger<HomeController> logger, IAdminConfigService adminConfigService)
        {
            _logger = logger;
            _adminService = adminConfigService; 

        }
        

        
        public string Index()
        {
            

            string str = _adminService.adminEmail + "   ;   " + _adminService.adminName;

            return str;
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
