using System;
using System.Collections.Generic;
using System.Text;

namespace MostarGuide.Model.Requests
{
    public class TerminiUpsertRequest
    {
        public int IzletId { get; set; }
        public int VodicId { get; set; }
        public DateTime VrijemeTermina { get; set; }
    }
}
