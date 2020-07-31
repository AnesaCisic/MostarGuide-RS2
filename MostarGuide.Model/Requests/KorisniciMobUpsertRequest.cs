using System;
using System.Collections.Generic;
using System.Text;

namespace MostarGuide.Model.Requests
{
    public class KorisniciMobUpsertRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
    }
}
