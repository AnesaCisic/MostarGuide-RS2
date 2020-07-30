using System;
using System.Collections.Generic;
using System.Text;

namespace MostarGuide.Model.Requests
{
    public class RezervacijeUpsertRequest
    {
        public int RezervacijaId { get; set; }
        public int TerminId { get; set; }
        public int KorisnikMobId { get; set; }

        public DateTime DatumRezervacije { get; set; }
        public int BrojOsoba { get; set; }
    }
}
