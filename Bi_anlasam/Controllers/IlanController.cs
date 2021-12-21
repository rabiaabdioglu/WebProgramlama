using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bi_anlasam;
using Bi_anlasam.Models;

namespace Bi_anlasam.Controllers
{
    public class IlanController : Controller
    {
        private readonly BianlasamDbContext _context;

        public IlanController(BianlasamDbContext context)
        {
            _context = context;
        }

        // GET: Ilan
        public async Task<IActionResult> Index()
        {
            var bianlasamDbContext = _context.Ilan.Include(i => i.Ders.Alan).Include(i => i.Ders).Include(i => i.Kullanici);
            return View(await bianlasamDbContext.ToListAsync());
        }


        public async Task<IActionResult> Ilan()
        {
            

            var bianlasamDbContext = _context.Ilan.Include(i => i.Ders)
                .Include(i => i.Kullanici);
            return View(await bianlasamDbContext.ToListAsync());
        }
        public async Task<IActionResult> SecilenIlan(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ilan = await _context.Ilan
                .Include(i => i.Ders)
                .Include(i => i.Kullanici)
                .FirstOrDefaultAsync(m => m.IlanId == id);
            if (ilan == null)
            {
                return NotFound();
            }

            return View(ilan);
        }








        //// GET: Ilan/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var ilan = await _context.Ilan
        //        .Include(i => i.Ders)
        //        .Include(i => i.Kullanici)
        //        .FirstOrDefaultAsync(m => m.IlanId == id);
        //    if (ilan == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(ilan);
        //}

        //// GET: Ilan/Create
        //public IActionResult Create()
        //{
        //    ViewData["DersId"] = new SelectList(_context.Ders, "DersId", "DersId");
        //    ViewData["KullaniciId"] = new SelectList(_context.Kullanici, "KullaniciId", "KullaniciId");
        //    return View();
        //}

        //// POST: Ilan/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("IlanId,IlanTarihi,KullaniciId,DersId,Baslik,Aciklama,IlanDurum")] Ilan ilan)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(ilan);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["DersId"] = new SelectList(_context.Ders, "DersId", "DersId", ilan.DersId);
        //    ViewData["KullaniciId"] = new SelectList(_context.Kullanici, "KullaniciId", "KullaniciId", ilan.KullaniciId);
        //    return View(ilan);
        //}

        //// GET: Ilan/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var ilan = await _context.Ilan.FindAsync(id);
        //    if (ilan == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["DersId"] = new SelectList(_context.Ders, "DersId", "DersId", ilan.DersId);
        //    ViewData["KullaniciId"] = new SelectList(_context.Kullanici, "KullaniciId", "KullaniciId", ilan.KullaniciId);
        //    return View(ilan);
        //}

        //// POST: Ilan/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("IlanId,IlanTarihi,KullaniciId,DersId,Baslik,Aciklama,IlanDurum")] Ilan ilan)
        //{
        //    if (id != ilan.IlanId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(ilan);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!IlanExists(ilan.IlanId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["DersId"] = new SelectList(_context.Ders, "DersId", "DersId", ilan.DersId);
        //    ViewData["KullaniciId"] = new SelectList(_context.Kullanici, "KullaniciId", "KullaniciId", ilan.KullaniciId);
        //    return View(ilan);
        //}

        //// GET: Ilan/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var ilan = await _context.Ilan
        //        .Include(i => i.Ders)
        //        .Include(i => i.Kullanici)
        //        .FirstOrDefaultAsync(m => m.IlanId == id);
        //    if (ilan == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(ilan);
        //}

        //// POST: Ilan/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var ilan = await _context.Ilan.FindAsync(id);
        //    _context.Ilan.Remove(ilan);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool IlanExists(int id)
        //{
        //    return _context.Ilan.Any(e => e.IlanId == id);
        //}
    }
}
