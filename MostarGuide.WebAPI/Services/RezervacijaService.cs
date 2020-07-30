using AutoMapper;
using MostarGuide.Model.Requests;
using MostarGuide.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Services
{
    public class RezervacijaService : BaseCRUDService<Model.Rezervacije, RezervacijeSearchRequest, Database.Rezervacije, RezervacijeUpsertRequest, RezervacijeUpsertRequest>, ICRUDService<Model.Rezervacije, RezervacijeSearchRequest, RezervacijeUpsertRequest, RezervacijeUpsertRequest>
    {
        public RezervacijaService(MostarGuideContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Rezervacije> Get(RezervacijeSearchRequest search)
        {
            var query = _context.Set<Rezervacije>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.ImeKorisnika))
            {
                query = query.Where(x => x.Korisnik.Ime.StartsWith(search.ImeKorisnika));
            }

            if (!string.IsNullOrWhiteSpace(search?.PrezimeKorisnika))
            {
                query = query.Where(x => x.Korisnik.Prezime.StartsWith(search.PrezimeKorisnika));
            }

            if (!string.IsNullOrWhiteSpace(search?.Izlet))
            {
                query = query.Where(x => x.Termin.Izlet.Naziv.StartsWith(search.Izlet));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Rezervacije>>(list);
        }
    }
}
