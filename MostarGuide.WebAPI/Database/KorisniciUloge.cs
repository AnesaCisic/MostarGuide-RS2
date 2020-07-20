using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Database
{
    public partial class KorisniciUloge
    {
        public int KorisnikUlogaId { get; set; }

        public int KorisnikId { get; set; }
        public Korisnici Korisnik { get; set; }

        public int UlogaId { get; set; }
        public Uloge Uloga { get; set; }

        public DateTime DatumIzmjene { get; set; }
    }
}
