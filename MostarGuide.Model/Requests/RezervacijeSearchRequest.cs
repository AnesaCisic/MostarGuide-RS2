using System;
using System.Collections.Generic;
using System.Text;

namespace MostarGuide.Model.Requests
{
    public class RezervacijeSearchRequest
    {
        public int? TerminId { get; set; }
        public int? Godina { get; set; }
        public int? KorisnikId { get; set; }

    }
}
