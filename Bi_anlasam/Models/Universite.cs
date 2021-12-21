using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bi_anlasam.Models
{
    public class Universite
    {
        [Key]
        public int UniversiteId { get; set; }

        [StringLength(80)]

        public string UniversiteAd { get; set; }
    }
}
