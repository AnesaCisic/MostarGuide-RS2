using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Database
{
    public partial class Uplate
    {
        [Key]
        public int UplataID { get; set; }
        public int RezervacijaID { get; set; }
        public Rezervacije Rezervacija { get; set; }
        public DateTime DatumUplate { get; set; }
        public decimal Iznos { get; set; }

    }
}
