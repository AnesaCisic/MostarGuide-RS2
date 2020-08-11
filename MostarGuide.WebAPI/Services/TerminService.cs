using AutoMapper;
using MostarGuide.Model.Requests;
using MostarGuide.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Services
{
    public class TerminService : BaseCRUDService<Model.Termini, TerminiSearchRequest, Database.Termini, TerminiUpsertRequest, TerminiUpsertRequest>, ICRUDService<Model.Termini, TerminiSearchRequest, TerminiUpsertRequest, TerminiUpsertRequest>
    {
        public TerminService(MostarGuideContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Termini> Get(TerminiSearchRequest search)
        {
            var query = _context.Set<Termini>().AsQueryable();

            if (search.KorisnikId.HasValue && search.Datum.HasValue)
            {
                query = query.Where(x => x.KorisnikId == search.KorisnikId && DateTime.Compare( x.VrijemeTermina.Date, search.Datum.Value.Date)==0);
            }

            if (search.KorisnikId.HasValue == true)
            {
                query = query.Where(x => x.KorisnikId == search.KorisnikId);
            }

            if (search.IzletId.HasValue == true)
            {
                query = query.Where(x => x.IzletId == search.IzletId);
            }


            var  list = query.OrderByDescending(x => x.VrijemeTermina).ToList();
   
            return _mapper.Map<List<Model.Termini>>(list);
        }

    }
}
