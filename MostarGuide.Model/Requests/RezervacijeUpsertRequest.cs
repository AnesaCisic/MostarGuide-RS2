using System;
using System.Collections.Generic;
using System.Text;

namespace MostarGuide.Model.Requests
{
    public class RezervacijeUpsertRequest
    {
        public int TerminId { get; set; }
        public int KorisnikMobId { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public int BrojOsoba { get; set; }
        public decimal UkupanIznos { get; set; }
        public bool Placeno { get; set; }
    }
}
