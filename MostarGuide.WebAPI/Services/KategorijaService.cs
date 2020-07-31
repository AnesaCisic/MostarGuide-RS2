using AutoMapper;
using MostarGuide.Model.Requests;
using MostarGuide.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Services
{
    public class KategorijaService : BaseCRUDService<Model.Kategorije, object, Database.Kategorije, KategorijeUpsertRequest, KategorijeUpsertRequest>, ICRUDService<Model.Kategorije, object, KategorijeUpsertRequest, KategorijeUpsertRequest>
    {
        public KategorijaService(MostarGuideContext context, IMapper mapper) : base(context, mapper)
        {
        }

    }
}
