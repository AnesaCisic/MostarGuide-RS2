using AutoMapper;
using MostarGuide.Model.Requests;
using MostarGuide.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Services
{
    public class OcjenaIzletService : BaseCRUDService<Model.OcjeneIzleti, OcjeneIzletiSearchRequest, Database.OcjeneIzleti, OcjeneIzletiUpsertRequest, OcjeneIzletiUpsertRequest>, ICRUDService<Model.OcjeneIzleti, OcjeneIzletiSearchRequest, OcjeneIzletiUpsertRequest, OcjeneIzletiUpsertRequest>
    {
        public OcjenaIzletService(MostarGuideContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.OcjeneIzleti> Get(OcjeneIzletiSearchRequest search)
        {

            var query = _context.OcjeneIzleti.AsQueryable();

            if (search.IzletId.HasValue == true)
            {
                query = query.Where(x => x.IzletId == search.IzletId);
            }

            var list = query.OrderByDescending(x=> x.Ocjena).ToList();
            return _mapper.Map<List<Model.OcjeneIzleti>>(list);
        }
    }
}
