﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MostarGuide.Model.Requests
{
    public class OcjeneIzletiUpsertRequest
    {
        //public int OcjenaId { get; set; }
        public int IzletId { get; set; }
        public int KorisnikId { get; set; }
        public DateTime Datum { get; set; }
        public int Ocjena { get; set; }
    }
}