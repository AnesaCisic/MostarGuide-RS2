using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Database
{
    public partial class OcjeneSekcije
    {
        public int OcjenaId { get; set; }
        public int SekcijaId { get; set; }
        public int KorisnikId { get; set; }
        public DateTime Datum { get; set; }
        public int Ocjena { get; set; }

        public virtual Sekcije Sekcije { get; set; }
        public virtual KorisniciMob Korisnik { get; set; }
    }
}
