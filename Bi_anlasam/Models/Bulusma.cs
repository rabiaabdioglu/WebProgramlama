using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bi_anlasam.Models
{
    public class Bulusma
    {
        [Key]
        public int BulusmaId { get; set; }

    
        public int Puan { get; set; }



        public string Yorum { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy H:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime BulusmaTarihi { get; set; }

        //ilişki
      
        public Teklif Teklif { get; set; }
        [ForeignKey("TeklifId")]
        public int TeklifId { get; set; }

    }
}
