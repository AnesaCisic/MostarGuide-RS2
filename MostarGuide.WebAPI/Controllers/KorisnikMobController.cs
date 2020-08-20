using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MostarGuide.Model;
using MostarGuide.Model.Requests;
using MostarGuide.WebAPI.Services;

namespace MostarGuide.WebAPI.Controllers
{
    public class KorisnikMobController : BaseCRUDController<Model.KorisniciMob, KorisniciMobSearchRequest, KorisniciMobUpsertRequest, KorisniciMobUpsertRequest>
    {
        public KorisnikMobController(ICRUDService<KorisniciMob, KorisniciMobSearchRequest, KorisniciMobUpsertRequest, KorisniciMobUpsertRequest> service) : base(service)
        {
        }

    }
}
