using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Services
{
    public interface ILoginService
    {
        Model.KorisnikLogin Authenticiraj(string username, string pass);
        Model.KorisnikLogin AuthenticirajKorisnikMob(string username, string pass);
        bool ProvjeriKorisnika(string username);
    }
}
