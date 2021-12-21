using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bi_anlasam.Models
{
    public class Teklif
    {

        [Key]
        public int TeklifId { get; set; }


        public Ilan Ilan { get; set; }
        [ForeignKey("IlanId")]

        public int IlanId { get; set; }

        [ForeignKey("TeklifVerenKullaniciId")]
      public int TeklifVerenKullaniciId { get; set; }
        
     
        public int Fiyat { get; set; }



    }
}
