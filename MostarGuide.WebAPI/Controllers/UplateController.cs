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
    [Route("api/[controller]")]
    [ApiController]
    public class UplateController : BaseCRUDController<Uplate, UplateSearchRequest, UplateInsertRequest, UplateInsertRequest>
    {
        public UplateController(ICRUDService<Uplate, UplateSearchRequest, UplateInsertRequest, UplateInsertRequest> service) : base(service)
        {
        }
    }
}
