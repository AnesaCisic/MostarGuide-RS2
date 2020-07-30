using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MostarGuide.Model
{
    public class Termini
    {
        public int TerminId { get; set; }
        public int? IzletId { get; set; }
        public int? KorisnikId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }

        [DataType(DataType.Time)]
        public DateTime Vrijeme { get; set; }
    }
}
