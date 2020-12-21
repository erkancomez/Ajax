using Ajax.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Ajax.Controllers
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
        public IActionResult List()
        {
            Thread.Sleep(3000);
            var jsonKullanicilar = JsonConvert.SerializeObject(KullaniciIslem.GetAll());
            return Json(jsonKullanicilar);
        }
        public IActionResult GetById(int kullaniciId)
        {
            var bulunanKallanici = KullaniciIslem.GetById(kullaniciId);
            var jsonKullanici = JsonConvert.SerializeObject(bulunanKallanici);

            return Json(jsonKullanici);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public IActionResult Add(Kullanici kullanici)
        {
            KullaniciIslem.Add(kullanici);
            var jsonKullanci = JsonConvert.SerializeObject(kullanici);
            return Json(jsonKullanci);
        }
    }
}
