﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MostarGuide.Model.Requests
{
    public class SekcijeUpsertRequest
    {
        public int KategorijaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Adresa { get; set; }
        public string Webstranica { get; set; }
        public byte[] Slika { get; set; }
    }
}
