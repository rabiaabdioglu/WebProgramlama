using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bi_anlasam.Models
{
    public class Sehir
    {


        [Key]
        public int SehirId { get; set; }

        [StringLength(80)]

        public string SehirAd { get; set; }
        public ICollection<Ilce> Ilce { get; set; }

    }
}