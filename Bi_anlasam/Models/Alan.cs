using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bi_anlasam.Models
{
    public class Alan
    {
        [Key]
        public int AlanId { get; set; }

        [StringLength(80)]

        public string AlanAd { get; set; }

        public List<Ders> Dersler { get; set; }
    }
}
