using System;
using System.Collections.Generic;
using System.Text;

namespace MostarGuide.Model
{
    public class Termini
    {
        public int TerminId { get; set; }
        public int? IzletId { get; set; }
        public int? VodicId { get; set; }
        public DateTime VrijemeTermina { get; set; }
    }
}
