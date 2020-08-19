using System;
using System.Collections.Generic;
using System.Text;

namespace MostarGuide.Model
{
    public class Sekcije
    {
        public int SekcijaId { get; set; }
        public int KategorijaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Adresa { get; set; }
        public string Webstranica { get; set; }
        public decimal Ocjena { get; set; }
        public byte[] Slika { get; set; }
    }
}
