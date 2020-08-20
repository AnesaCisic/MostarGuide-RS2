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

    public class IzletController : BaseCRUDController<Model.Izleti, IzletiSearchRequest, IzletiUpsertRequest, IzletiUpsertRequest>
    {
        public IzletController(ICRUDService<Izleti, IzletiSearchRequest, IzletiUpsertRequest, IzletiUpsertRequest> service) : base(service)
        {
        }
    }
}
