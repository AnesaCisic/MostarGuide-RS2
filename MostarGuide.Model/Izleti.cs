using System;
using System.Collections.Generic;
using System.Text;

namespace MostarGuide.Model
{
    public class Izleti
    {
        public int IzletId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int BrojMjesta { get; set; }
        public decimal Cijena { get; set; }
        public byte[] Slika { get; set; }
        //public bool? Status { get; set; }
    }
}
