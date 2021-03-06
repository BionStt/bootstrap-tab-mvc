using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Template2.Models;

namespace Template2.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

          public ActionResult FirstTab()
        {
            return PartialView("_FirstTab");
        }

        public ActionResult SecondTab()
        {
            return PartialView("_SecondTab");
        }
         public ActionResult Lainnya()
        {
            return PartialView("_Lainnya");
        }
         public ActionResult PengajuanPembukaanRekening()
        {
            return PartialView("_PengajuanPembukaanRekening");
        }
         public ActionResult ProfilingResiko()
        {
            return PartialView("_ProfilingResiko");
        }
         public ActionResult _Lampiran()
        {
            return PartialView("_Lampiran");
        }
    }
}
