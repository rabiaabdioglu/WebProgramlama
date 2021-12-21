using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bi_anlasam.Controllers
{
    public class KayitGirisController : Controller
    {
        private readonly BianlasamDbContext _context;

        public KayitGirisController(BianlasamDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult KayitOl()
        {
            return View();
        }
        public IActionResult GirisYap()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GirisYap(string email , string sifre)
        {
            var kullanici = _context.Kullanici.FirstOrDefault(w => w.Email.Equals(email) && w.Sifre.Equals(sifre));
            if (kullanici != null)
            {
                HttpContext.Session.SetInt32("id", kullanici.KullaniciId);
                HttpContext.Session.SetString("KullaniciAdi", kullanici.Adi + " " + kullanici.Soyadi);
                return Redirect("/Home/Index");
            }



            return Redirect("GirisYap");
        }
        [HttpGet]
        public IActionResult CikisYap()
        {
            HttpContext.Session.Clear();
            return Redirect("/Home/Index");
        }

    }
}
