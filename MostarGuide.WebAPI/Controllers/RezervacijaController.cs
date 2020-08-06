using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MostarGuide.Model;
using MostarGuide.Model.Requests;
using MostarGuide.WebAPI.Services;

namespace MostarGuide.WebAPI.Controllers
{
    public class RezervacijaController : BaseCRUDController<Model.Rezervacije, RezervacijeSearchRequest, RezervacijeUpsertRequest, RezervacijeUpsertRequest>
    {
        public RezervacijaController(ICRUDService<Rezervacije, RezervacijeSearchRequest, RezervacijeUpsertRequest, RezervacijeUpsertRequest> service) : base(service)
        {
        }

    }
}
