using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MostarGuide.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Services
{
    public class PreporukaService : IPreporukaService
    {
        private readonly MostarGuideContext _context;
        private readonly IMapper _mapper;
        public int BrojPreporuka = 5;

        public PreporukaService(MostarGuideContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Sekcije> GetPreporuka(int korisnikId)
        {
            List<Favoriti> MojiFavoriti = _context.Favoriti.Where(x => x.KorisnikId == korisnikId)
                .Include(x => x.Sekcija.Kategorija)
                .ToList();

            if (MojiFavoriti.Count() > 0)
            {
                List<Kategorije> sveKategorije = new List<Kategorije>();

                foreach (var favorit in MojiFavoriti)
                {
                    
                    var kategorija = favorit.Sekcija.Kategorija;

                    bool add = true;
                    for (int i = 0; i < sveKategorije.Count; i++)
                    {
                        if (kategorija.KategorijaId == sveKategorije[i].KategorijaId)
                        {
                            add = false;
                        }
                    }

                    if (add)
                    {
                        sveKategorije.Add(kategorija);
                    }
                }

                List<Sekcije> ListaPreporucenihSekcija = new List<Sekcije>();
                
                foreach (var k in sveKategorije)
                {
                   
                    var SekcijeIzKategorije = _context.Sekcije
                        .Where(n => n.KategorijaId == k.KategorijaId).ToList();

                    foreach (var sekcija in SekcijeIzKategorije)
                    {
                        bool add = true;
                        for (int i = 0; i < ListaPreporucenihSekcija.Count; i++)
                        {
                            if (sekcija.SekcijaId == ListaPreporucenihSekcija[i].SekcijaId)
                            {
                                add = false;
                            }
                        }

                        foreach (var favorit in MojiFavoriti)
                        {
                            if (sekcija.SekcijaId == favorit.Sekcija.SekcijaId)
                            {
                                add = false;
                            }
                        }

                        if (add)
                        {
                            ListaPreporucenihSekcija.Add(sekcija);
                        }
                    }
                }

                ListaPreporucenihSekcija = ListaPreporucenihSekcija.OrderBy(x => Guid.NewGuid()).Take(BrojPreporuka).ToList();

                if (ListaPreporucenihSekcija.Count == 0)
                {
                    ListaPreporucenihSekcija = _context.Sekcije.Take(BrojPreporuka).OrderBy(x => Guid.NewGuid()).ToList();
                }

                var list2 = _mapper.Map<List<Model.Sekcije>>(ListaPreporucenihSekcija);
                foreach (var sekcija in list2)
                {
                    sekcija.Ocjena = _context.OcjeneSekcije
                        .Where(x => x.SekcijaId == sekcija.SekcijaId)
                        .Average(x => (decimal?)x.Ocjena) ?? new decimal(0);
                }

                return list2;
            }

            var ListaSvihSekcija = _context.Sekcije.Take(BrojPreporuka).OrderBy(x => Guid.NewGuid()).ToList();
            var list1 = _mapper.Map<List<Model.Sekcije>>(ListaSvihSekcija);

            foreach (var sekcija in list1)
            {
                sekcija.Ocjena = _context.OcjeneSekcije
                    .Where(x => x.SekcijaId == sekcija.SekcijaId)
                    .Average(x => (decimal?)x.Ocjena) ?? new decimal(0);
            }

            return list1;
        }
    }
}
