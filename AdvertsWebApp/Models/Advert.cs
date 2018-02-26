using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdvertsWebApp.Models
{
    public class Advert
    {
        public int AdvertId { get; set; }

        [DisplayName("Sludinājuma cena")]
        [Required]
        public double Price { get; set; }

        [DisplayName("Sludinājuma nosaukums")]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set;  }

        //Izmantojam Display atribūtu, lai pateiktu aplikācijai, kā lauks jānosauc uzģenerētā Htmlā.
        //Šo izmanto LableFor() un ValidationFor() funkcijas no html klases
        [DisplayName("Sludinājuma teksts")]
        public string AdvertText { get; set; }
        public DateTime CreationTime { get; set; }
    }
}