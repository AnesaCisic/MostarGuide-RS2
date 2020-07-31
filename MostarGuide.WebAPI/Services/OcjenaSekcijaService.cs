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

            if (search.Ocjena != 0)
            {
                query = query.Where(x => x.Ocjena == search.Ocjena);
            }

            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                query = query.Where(x => x.Korisnik.KorisnickoIme.StartsWith(search.KorisnickoIme));
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.OcjeneSekcije>>(list);
        }
    }
}
