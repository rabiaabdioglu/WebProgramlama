using Bi_anlasam.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bi_anlasam
{
    public class BianlasamDbContext : IdentityDbContext
    {
        public DbSet<Alan> Alan { get; set; }
        public DbSet<Bulusma> Bulusma { get; set; }
        public DbSet<Ders> Ders { get; set; }
        public DbSet<Ilan> Ilan { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Sehir> Sehir { get; set; }
        public DbSet<Teklif> Teklif { get; set; }
        public DbSet<Universite> Universite { get; set; }


        public BianlasamDbContext(DbContextOptions<BianlasamDbContext> options)
            : base(options)
        {
        }
    }
}