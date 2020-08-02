using AutoMapper;
using MostarGuide.Model.Requests;
using MostarGuide.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Services
{
    public class OcjenaSekcijaService : BaseCRUDService<Model.OcjeneSekcije, OcjeneSekcijeSearchRequest, Database.OcjeneSekcije, OcjeneSekcijeUpsertRequest, OcjeneSekcijeUpsertRequest>, ICRUDService<Model.OcjeneSekcije, OcjeneSekcijeSearchRequest, OcjeneSekcijeUpsertRequest, OcjeneSekcijeUpsertRequest>
    {
        public OcjenaSekcijaService(MostarGuideContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.OcjeneSekcije> Get(OcjeneSekcijeSearchRequest search)
        {

            var query = _context.OcjeneSekcije.AsQueryable();

            if (search.SekcijaId.HasValue == true)
            {
                query = query.Where(x => x.SekcijaId == search.SekcijaId);
            }

            var list = query.OrderByDescending(x => x.Ocjena).ToList();
            return _mapper.Map<List<Model.OcjeneSekcije>>(list);
        }
    }
}
