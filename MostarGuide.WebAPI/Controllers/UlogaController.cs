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
    public class UlogaController : BaseController<Model.Uloge, object>
    {
        public UlogaController(IService<Uloge, object> service) : base(service)
        {
        }
    }
}
