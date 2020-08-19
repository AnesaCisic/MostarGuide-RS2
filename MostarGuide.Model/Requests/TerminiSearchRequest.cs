using System;
using System.Collections.Generic;
using System.Text;

namespace MostarGuide.Model.Requests
{
    public class TerminiSearchRequest
    {
        public int? KorisnikId { get; set; }
        public int? IzletId { get; set; }
        public DateTime? Datum { get; set; }

    }
}
