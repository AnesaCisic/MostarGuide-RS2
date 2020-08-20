using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MostarGuide.Model.Requests;
using MostarGuide.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Services
{
        public class FavoritiService : BaseCRUDService<Model.Favoriti, FavoritiSearchRequest, Database.Favoriti, FavoritiUpsertRequest, FavoritiUpsertRequest>
        {
            public FavoritiService(MostarGuideContext context, IMapper mapper) : base(context, mapper)
            {

            }

            public override List<Model.Favoriti> Get(FavoritiSearchRequest search)
            {
                var query = _context.Set<Favoriti>().AsQueryable();


                if (search.SekcijaId.HasValue == true)
                {
                    query = query.Where(x => x.SekcijaId == search.SekcijaId);
                }

                if (search.KorisnikId.HasValue == true)
                {
                    query = query.Where(x => x.KorisnikId == search.KorisnikId).Include(x => x.Sekcija);
                }

                var list = query.ToList();
                return _mapper.Map<List<Model.Favoriti>>(list);
            }

        }
    
}
