﻿using AutoMapper;
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

            if (search.Ocjena != 0)
            {
                query = query.Where(x => x.Ocjena == search.Ocjena);
            }

            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                query = query.Where(x => x.Korisnik.KorisnickoIme.StartsWith(search.KorisnickoIme));
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.OcjeneIzleti>>(list);
        }
    }
}