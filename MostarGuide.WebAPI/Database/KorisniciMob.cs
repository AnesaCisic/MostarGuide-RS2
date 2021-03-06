﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Database
{
    public partial class KorisniciMob
    {
        public KorisniciMob()
        {
            OcjeneIzleti = new HashSet<OcjeneIzleti>();
            OcjeneSekcije = new HashSet<OcjeneSekcije>();
            Rezervacije = new HashSet<Rezervacije>();
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }

        public virtual ICollection<OcjeneIzleti> OcjeneIzleti { get; set; }
        public virtual ICollection<OcjeneSekcije> OcjeneSekcije { get; set; }
        public virtual ICollection<Rezervacije> Rezervacije { get; set; }
    }
}
