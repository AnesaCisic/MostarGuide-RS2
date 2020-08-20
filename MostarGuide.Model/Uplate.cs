using System;
using System.Collections.Generic;
using System.Text;

namespace MostarGuide.Model
{
    public class Uplate
    {
        public int UplataID { get; set; }
        public int RezervacijaID { get; set; }
        public decimal Iznos { get; set; }
        public DateTime DatumUplate { get; set; }

    }
}
