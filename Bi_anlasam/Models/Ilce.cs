using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bi_anlasam.Models
{
    public class Ilce
    {
        [Key]
        public int IlceId { get; set; }
        public int IlceAd { get; set; }
        public Sehir Sehir { get; set; }
        [ForeignKey("SehirId")]

        public int SehirId { get; set; }
    }
}
