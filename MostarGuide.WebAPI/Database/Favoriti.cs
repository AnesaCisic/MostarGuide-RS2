using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Database
{
        public partial class Favoriti
        {
            [Key]
            public int FavoritId { get; set; }
            public int KorisnikId { get; set; }
            public KorisniciMob Korisnik { get; set; }
            public int SekcijaId { get; set; }
            public Sekcije Sekcija { get; set; }
        }
}
