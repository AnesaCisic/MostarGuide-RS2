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
            //if (!string.IsNullOrWhiteSpace(search?.ImeVodica))
            //{
            //    query = query.Where(x => x.Vodic.Ime.StartsWith(search.ImeVodica));
            //}

            //if (!string.IsNullOrWhiteSpace(search?.PrezimeVodica))
            //{
            //    query = query.Where(x => x.Vodic.Prezime.StartsWith(search.PrezimeVodica));
            //}

            //if (!string.IsNullOrWhiteSpace(search?.Izlet))
            //{
            //    query = query.Where(x => x.Izlet.Naziv.StartsWith(search.Izlet));
            //}

            if (search.KorisnikId.HasValue == true)
            {
                query = query.Where(x => x.KorisnikId == search.KorisnikId);
            }

     
            var  list = query.OrderByDescending(x => x.Datum).ToList();
   
            return _mapper.Map<List<Model.Termini>>(list);
        }

    }
}
