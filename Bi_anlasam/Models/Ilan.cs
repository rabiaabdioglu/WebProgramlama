using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bi_anlasam.Models
{

    public class Ilan
    {



        [Key]
        public int IlanId { get; set; }



        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy H:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime IlanTarihi { get; set; }


        public Kullanici Kullanici { get; set; }    
        [ForeignKey("KullaniciId")]

        public int KullaniciId { get; set; }
     
        

        public Ders Ders { get; set; }  
        [ForeignKey("DersId")]

        public int DersId { get; set; }
        public Ilce Ilce { get; set; }
        [ForeignKey("IlceId")]

        public int IlceId { get; set; }

        public int Fiyat { get; set; }

        public string Baslik { get; set; }

        public string Aciklama { get; set; }
        public bool IlanDurum { get; set; }

    }
}
