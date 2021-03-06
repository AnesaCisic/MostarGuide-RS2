﻿using AutoMapper;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
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

            if (search.TerminId.HasValue && search.Godina.HasValue)
            {
                query = query.Where(x => x.TerminId == search.TerminId && x.DatumRezervacije.Year == search.Godina);
            }

            if (search.TerminId.HasValue == true)
            {
                query = query.Where(x => x.TerminId == search.TerminId);
            }

            if (search.KorisnikId.HasValue == true)
            {
                query = query.Where(x => x.KorisnikMobId == search.KorisnikId);
            }

            var list = query.OrderBy(x => x.DatumRezervacije).ToList();

            return _mapper.Map<List<Model.Rezervacije>>(list);
        }

    }
}
