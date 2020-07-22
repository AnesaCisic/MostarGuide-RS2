using AutoMapper;
using MostarGuide.Model.Requests;
using MostarGuide.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Services
{
    public class SekcijaService : BaseCRUDService<Model.Sekcije, SekcijeSearchRequest, Database.Sekcije, SekcijeUpsertRequest, SekcijeUpsertRequest>, ICRUDService<Model.Sekcije, SekcijeSearchRequest, SekcijeUpsertRequest, SekcijeUpsertRequest>
    {
        public SekcijaService(MostarGuideContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Sekcije> Get(SekcijeSearchRequest search)
        {
            var query = _context.Set<Sekcije>().AsQueryable();
            

            if (search.KategorijaId.HasValue == true)
            {
                query = query.Where(x => x.KategorijaId == search.KategorijaId);
            }


            query = query.OrderBy(x => x.Naziv);
            var list = query.ToList();
            return _mapper.Map<List<Model.Sekcije>>(list);
        }


    }
}
