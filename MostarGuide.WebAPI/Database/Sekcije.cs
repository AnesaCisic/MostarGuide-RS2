using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Database
{
    public partial class Sekcije
    {
        public Sekcije()
        {
            Ocjene = new HashSet<OcjeneSekcije>();
        }
        public int SekcijaId { get; set; }
        public int KategorijaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Adresa { get; set; }
        public string Webstranica { get; set; }
        public byte[] Slika { get; set; }

        public virtual Kategorije Kategorija { get; set; }
        public virtual ICollection<OcjeneSekcije> Ocjene { get; set; }

    }
}
