using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Database
{
    public partial class Izleti
    {
        public Izleti()
        {
            Ocjene = new HashSet<OcjeneIzleti>();
            Termini = new HashSet<Termini>();
        }

        public int IzletId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int BrojMjesta { get; set; }
        public decimal Cijena { get; set; }
        public byte[] Slika { get; set; }
        //public bool? Status { get; set; }

        public virtual ICollection<OcjeneIzleti> Ocjene { get; set; }
        public virtual ICollection<Termini> Termini { get; set; }
    }
}
