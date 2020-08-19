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
    [Authorize(Roles = "Administrator")]
    public class OcjenaSekcijaController : BaseCRUDController<Model.OcjeneSekcije, OcjeneSekcijeSearchRequest, OcjeneSekcijeUpsertRequest, OcjeneSekcijeUpsertRequest>
    {
        public OcjenaSekcijaController(ICRUDService<OcjeneSekcije, OcjeneSekcijeSearchRequest, OcjeneSekcijeUpsertRequest, OcjeneSekcijeUpsertRequest> service) : base(service)
        {
        }

    }
}
