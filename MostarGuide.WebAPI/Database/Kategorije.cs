using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Database
{
    public partial class Kategorije
    {
        public Kategorije()
        {
            Sekcije = new HashSet<Sekcije>();
        }

        public int KategorijaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Sekcije> Sekcije { get; set; }
    }
}
