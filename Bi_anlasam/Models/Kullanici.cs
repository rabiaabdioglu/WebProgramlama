using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bi_anlasam.Models
{

    public class Kullanici
    {
        [Key]
        public int KullaniciId { get; set; }

       public string Email { get; set; }
       public string Sifre { get; set; }


        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string TamAd { get { return Adi + " " + Soyadi; } }


        public string Cinsiyet { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Doğum Tarihi")]
        public DateTime DogumTarihi { get; set; }

   
        public string Aciklama { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public DateTime KayitTarihi { get; set; }


      


   
        public int Telefon { get; set; }
        public int KullaniciPuani { get; set; }
        public bool HesapDurum { get; set; }  

        public bool IsAdmin { get; set; }  
         


        //ilişkiler
        public Universite Universite { get; set; }
        [ForeignKey("UniversiteId")]

        public int UniversiteId { get; set; }

        public string BolumAdi { get; set; }

        public Sehir Sehir { get; set; }  
        [ForeignKey("SehirId")]

        public int SehirId { get; set; }

        public ICollection<Ilan> Ilan { get; set; }

    }
}
