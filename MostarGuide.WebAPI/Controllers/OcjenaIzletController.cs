﻿using System;
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
    public class OcjenaIzletController : BaseCRUDController<Model.OcjeneIzleti, OcjeneIzletiSearchRequest, OcjeneIzletiUpsertRequest, OcjeneIzletiUpsertRequest>
    {
        public OcjenaIzletController(ICRUDService<OcjeneIzleti, OcjeneIzletiSearchRequest, OcjeneIzletiUpsertRequest, OcjeneIzletiUpsertRequest> service) : base(service)
        {
        }

    }
}
