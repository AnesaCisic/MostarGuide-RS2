using AutoMapper;
using MostarGuide.Model.Requests;
using MostarGuide.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Services
{
    public class IzletService : BaseCRUDService<Model.Izleti, IzletiSearchRequest, Database.Izleti, IzletiUpsertRequest, IzletiUpsertRequest>, ICRUDService<Model.Izleti, IzletiSearchRequest, IzletiUpsertRequest, IzletiUpsertRequest>
    {
        public IzletService(MostarGuideContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Izleti> Get(IzletiSearchRequest search)
        {

            var query = _context.Izleti.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.Izleti>>(list);
        }
    }
}
