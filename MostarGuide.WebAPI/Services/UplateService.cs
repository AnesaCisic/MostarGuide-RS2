using AutoMapper;
using MostarGuide.Model.Requests;
using MostarGuide.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Services
{
    public class UplateService : BaseCRUDService<Model.Uplate, UplateSearchRequest, Database.Uplate, UplateInsertRequest, UplateInsertRequest>
    {
        public UplateService(MostarGuideContext context, IMapper mapper) : base(context, mapper)
        {
        }

        //public override List<Uplate> Get(UplateSearchRequest search)
        //{
        //    var query = _context.Set<Uplate>().AsQueryable();

        //    if (search?.TerminId.HasValue == true)
        //    {
        //        //int i = (int)search.UtakmicaID;
        //        List<Termini> lista = _mapper.Map<List<Utakmica>>(_context.Set<Database.Utakmice>().ToList());

        //        Utakmica utakmica = null;
        //        foreach (var u in lista)
        //        {
        //            if (u.UtakmicaID == search.UtakmicaID)
        //                utakmica = u;
        //        }

        //        var id = utakmica.UtakmicaID;
        //        q = q.Where(s => s.Ulaznica.UtakmicaID == id);
        //    }

        //    var list = q.ToList();
        //    return _mapper.Map<List<Uplate>>(list);
        //}
    }
}
