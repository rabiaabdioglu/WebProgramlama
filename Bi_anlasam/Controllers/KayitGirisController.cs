using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using System.Collections.Generic;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Bi_anlasam.Models;

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
      [ValidateAntiForgeryToken]
        public async Task<IActionResult> KayitOl([Bind("Email,Sifre,Adi,Soyadi")] Kullanici kullanici)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kullanici);
                await _context.SaveChangesAsync();
                return Redirect("/Home/Index");
            }
            return Redirect("/KayitGiris/KayitOl");
        }

        [HttpPost]
        public IActionResult GirisYap(string email , string sifre)
        {
            var kullanici = _context.Kullanici.FirstOrDefault(w => w.Email.Equals(email) && w.Sifre.Equals(sifre));

            if (kullanici != null)
            {

                HttpContext.Session.SetInt32("id", kullanici.KullaniciId);
                HttpContext.Session.SetString("IsAdmin", kullanici.IsAdmin.ToString());
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
