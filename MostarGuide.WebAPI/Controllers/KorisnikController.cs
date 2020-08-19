using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MostarGuide.Model.Requests;
using MostarGuide.WebAPI.Services;

namespace MostarGuide.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Administrator")]
    public class KorisnikController : ControllerBase
    {
        
        private readonly IKorisniciService _korisnikService;
        public KorisnikController(IKorisniciService korisnikService)
        {
            _korisnikService = korisnikService;
        }

        [HttpGet]
        public List<Model.Korisnici> Get([FromQuery] KorisniciSearchRequest request)
        {
            return _korisnikService.Get(request);

        }

        //[Authorize(Roles = "Administrator")]
        [HttpGet("{id}")]
        public Model.Korisnici GetById(int id)
        {
            return _korisnikService.GetById(id);
        }

        [HttpPost]
        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            return _korisnikService.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Korisnici Update(int id, KorisniciInsertRequest request)
        {
            return _korisnikService.Update(id, request);
        }

    }
}
