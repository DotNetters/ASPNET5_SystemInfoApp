using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNET5SystemInfoApp.Models;
using ASPNET5SystemInfoApp.Services;
using Microsoft.AspNet.Mvc;

namespace ASPNET5SystemInfoApp.Controllers
{
    public class HomeController : Controller
    {
        private ISystemInfoService _systemInfoService;

        public HomeController(ISystemInfoService systemInfoService)
        {
            _systemInfoService = systemInfoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(new SystemInfoViewModel
            {
                SystemInfoServiceName = _systemInfoService.GetType().FullName,
                ServerName = Environment.MachineName,
                OSVersion = Environment.OSVersion.ToString(),
                InstalledSoftware = _systemInfoService.GetInstalledSoftware()
            });
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
