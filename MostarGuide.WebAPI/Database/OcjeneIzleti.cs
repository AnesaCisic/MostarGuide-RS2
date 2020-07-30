using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Database
{
    public partial class OcjeneIzleti
    {
        public int OcjenaId { get; set; }
        public int IzletId { get; set; }
        public int KorisnikId { get; set; }
        public DateTime Datum { get; set; }
        public int Ocjena { get; set; }

        public virtual Izleti Izlet { get; set; }
        public virtual KorisniciMob Korisnik { get; set; }
    }
}
