using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bi_anlasam.Controllers
{
    public class KurumsalController : Controller
    {
    

        public IActionResult GizlilikPolitikasi()
        {
            return View();
        }
        public IActionResult Hakkimizda()
        {
            return View();
        }
        public IActionResult Iletisim()
        {
            return View();
        }
        public IActionResult KullaniciSozlesmesi()
        {
            return View();
        }
        public IActionResult ToplulukKurallari()
        {
            return View();
        }

    }
}
