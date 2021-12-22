using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bi_anlasam.Models;
using Microsoft.EntityFrameworkCore;
using Bi_anlasam;

namespace WebDers7.Component
{
    public class TeklifListe:ViewComponent

    {

        private BianlasamDbContext database;
        public TeklifListe(BianlasamDbContext webContext)
        {

            database = webContext;

            }
        public async Task<IViewComponentResult> InvokeAsync(int? ilanId) { 

            var teklifler=database.Teklif.ToListAsync();

            return View(await teklifler);

        }
        public async Task<IViewComponentResult> Teklifler(int? id)
        {


            var bianlasamDbContext = database.Teklif.Include(i => i.Ilan).Include(i => i.TeklifVerenKullaniciId).Include(w => w.IlanId.Equals(id));

            return View(await bianlasamDbContext.ToListAsync());


        }

    }
}
