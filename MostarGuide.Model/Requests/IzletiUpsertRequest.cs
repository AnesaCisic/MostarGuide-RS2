﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MostarGuide.Model.Requests
{
    public class IzletiUpsertRequest
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int BrojMjesta { get; set; }
        public float Cijena { get; set; }
        //public byte[] Slika { get; set; }
        public bool? Status { get; set; }
    }
}
