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
    public class TerminController : BaseCRUDController<Model.Termini, TerminiSearchRequest, TerminiUpsertRequest, TerminiUpsertRequest>
    {
        public TerminController(ICRUDService<Termini, TerminiSearchRequest, TerminiUpsertRequest, TerminiUpsertRequest> service) : base(service)
        {
        }
    }
}
