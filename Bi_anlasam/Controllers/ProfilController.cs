using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bi_anlasam.Models;

namespace Bi_anlasam.Controllers
{
    public class ProfilController : Controller
    {
        private  BianlasamDbContext _context;

        public ProfilController(BianlasamDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Kullanici> profil = _context.Kullanici.ToList();

            return View(profil);
        }
     
        public async Task<IActionResult> Profil(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profil = await _context.Kullanici
                .Include(i => i.Sehir)
                .Include(i => i.Universite)
                .FirstOrDefaultAsync(m => m.KullaniciId == id);
            if (profil == null)
            {
                return NotFound();
            }

            return View(profil);
        }



    }
}
