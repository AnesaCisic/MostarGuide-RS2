using System;
using System.Collections.Generic;
using System.Text;

namespace MostarGuide.Model.Requests
{
    public class RezervacijeSearchRequest
    {
        public string ImeKorisnika { get; set; }
        public string PrezimeKorisnika { get; set; }
        public string Izlet { get; set; }

    }
}
