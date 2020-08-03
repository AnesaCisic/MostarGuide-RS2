using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MostarGuide.Model
{
    public class Termini
    {
        public int TerminId { get; set; }

        public int? KorisnikId { get; set; }
        public string Vodic { get; set; }

        public int? IzletId { get; set; }
        public string Izlet { get; set; }

        public DateTime VrijemeTermina { get; set; }

    }
}
