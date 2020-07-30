using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Database
{
    public partial class Termini
    {
        public Termini()
        {
            Rezervacije = new HashSet<Rezervacije>();
        }

        public int TerminId { get; set; }
        public int IzletId { get; set; }
        public int KorisnikId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }

        [DataType(DataType.Time)]
        public DateTime Vrijeme{ get; set; }

        public virtual Korisnici Korisnik { get; set; }
        public virtual Izleti Izlet { get; set; }
        public virtual ICollection<Rezervacije> Rezervacije { get; set; }
    }
}
