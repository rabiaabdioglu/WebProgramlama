using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bi_anlasam.Models
{
    public class Ders
    {
        [Key]
        public int DersId { get; set; }

        [StringLength(80)]

        public string DersAd { get; set; }


        //ilişki

        [ForeignKey("AlanId")]

        public int AlanId { get; set; }
        public Alan Alan { get; set; }

    }
}
