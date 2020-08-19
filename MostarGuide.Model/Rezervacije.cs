using System;
using System.Collections.Generic;
using System.Text;

namespace MostarGuide.Model
{
    public class Rezervacije
    {

        public int RezervacijaId { get; set; }
        public int? KorisnikMobId { get; set; }
        public string  Korisnik { get; set; }
        public int? TerminId { get; set; }
        public string Izlet { get; set; }
        public DateTime TerminDatum { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public decimal UkupanIznos { get; set; }
        public int BrojOsoba { get; set; }
        public bool Placeno { get; set; }


        public string DatumRezervacijeStr { get { return DatumRezervacije.ToString("dd MMM yyyy HH:mm"); } }

    }
}
