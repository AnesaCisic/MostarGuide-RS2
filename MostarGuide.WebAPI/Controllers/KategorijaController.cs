using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MostarGuide.Model;
using MostarGuide.WebAPI.Services;

namespace MostarGuide.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategorijaController : BaseController<Model.Kategorije, object>
    {
        public KategorijaController(IService<Kategorije, object> service) : base(service)
        {
        }
    }
}
