using System;
using System.Collections.Generic;
using System.Text;

namespace MostarGuide.Model
{
    public class KorisniciMob
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string KorisnickoIme { get; set; }
        public string ImePrezime { get { return Ime + " " + Prezime; } }

    }
}
