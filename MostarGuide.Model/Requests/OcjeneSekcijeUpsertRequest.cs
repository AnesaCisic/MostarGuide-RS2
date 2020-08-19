using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MostarGuide.Model.Requests
{
    public class OcjeneSekcijeUpsertRequest
    {
        public int SekcijaId { get; set; }
        public int KorisnikId { get; set; }
        public DateTime Datum { get; set; }
        public int Ocjena { get; set; }
    }
}
