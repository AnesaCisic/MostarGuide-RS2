using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Database
{
    public partial class Rezervacije
    {
        public int RezervacijaId { get; set; }
        public int TerminId { get; set; }
        public int KorisnikMobId { get; set; }

        public DateTime DatumRezervacije { get; set; }
        public int BrojOsoba { get; set; }

        public virtual Termini Termin { get; set; }
        public virtual KorisniciMob Korisnik { get; set; }

    }
}
