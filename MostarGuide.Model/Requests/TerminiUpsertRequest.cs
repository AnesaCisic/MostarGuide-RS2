using System;
using System.Collections.Generic;
using System.Text;

namespace MostarGuide.Model.Requests
{
    public class TerminiUpsertRequest
    {
        public int TerminId { get; set; }
        public int IzletId { get; set; }
        public int KorisnikId { get; set; }
        public DateTime DatumTermina { get; set; }
        public DateTime VrijemeTermina { get; set; }
    }
}
