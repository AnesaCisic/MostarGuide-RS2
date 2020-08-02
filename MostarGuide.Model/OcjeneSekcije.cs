using System;
using System.Collections.Generic;
using System.Text;

namespace MostarGuide.Model
{
    public class OcjeneSekcije
    {
        public int OcjenaId { get; set; }
        public int? SekcijaId { get; set; }
        public string Sekcija{ get; set; }
        public int? KorisnikId { get; set; }
        public string Korisnik { get; set; }
        public DateTime Datum { get; set; }
        public int Ocjena { get; set; }
    }
}
