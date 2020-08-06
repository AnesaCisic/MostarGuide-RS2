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
    public class KategorijaController : BaseCRUDController<Model.Kategorije, object, KategorijeUpsertRequest, KategorijeUpsertRequest>
    {
        public KategorijaController(ICRUDService<Kategorije, object, KategorijeUpsertRequest, KategorijeUpsertRequest> service) : base(service)
        {
        }
    }
}
