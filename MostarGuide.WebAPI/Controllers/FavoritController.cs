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
    [ApiController]
    public class FavoritController : BaseCRUDController<Model.Favoriti, FavoritiSearchRequest, FavoritiUpsertRequest, FavoritiUpsertRequest>
    {
        public FavoritController(ICRUDService<Favoriti, FavoritiSearchRequest, FavoritiUpsertRequest, FavoritiUpsertRequest> service) : base(service)
        {
        }

    }
}
