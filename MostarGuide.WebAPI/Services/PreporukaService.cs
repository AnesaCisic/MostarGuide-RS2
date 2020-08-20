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


        //Dictionary<int, List<OcjeneSekcije>> _sekcije = new Dictionary<int, List<OcjeneSekcije>>();
        public PreporukaService(MostarGuideContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Sekcije> GetPreporuka(int korisnikId)
        {
            //mojifavoriti include sekcija.kategorija
            List<Favoriti> MojiFavoriti = _context.Favoriti.Where(x => x.KorisnikId == korisnikId)
                .Include(x => x.Sekcija.Kategorija)
                .ToList();

            if (MojiFavoriti.Count() > 0)
            {
                //sve kategorije
                List<Kategorije> sveKategorije = new List<Kategorije>();
                //favorit in favorites
                foreach (var favorit in MojiFavoriti)
                {
                    //var kategorija = favorit.sekcija.kategorija predstavazanr
                    var kategorija = favorit.Sekcija.Kategorija;

                    bool add = true;
                    for (int i = 0; i < sveKategorije.Count; i++)
                    {
                        //kategorija.katid == svekat[i].katid
                        if (kategorija.KategorijaId == sveKategorije[i].KategorijaId)
                        {
                            add = false;
                        }
                    }

                    if (add)
                    {
                        //svekategorije.add(kategorija)
                        sveKategorije.Add(kategorija);
                    }
                }

                //list sekcija preporucene sekcije
                List<Sekcije> ListaPreporucenihSekcija = new List<Sekcije>();
                //za svaku aktegoriju u svekategorije
                foreach (var k in sveKategorije)
                {
                    //var sekcijetekategorije
                    var SekcijeIzKategorije = _context.Sekcije
                        .Where(n => n.KategorijaId == k.KategorijaId).ToList();

                    // za svaku sekciju iz sekcijetekategorije
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






        //public List<Model.Sekcije> GetPreporuka(int sekcijaId)
        //{
        //    UcitajSekcije(sekcijaId);
        //    List<OcjeneSekcije> ocjenePosmatraneSekcije = _context.OcjeneSekcije.Where(x => x.SekcijaId == sekcijaId).OrderBy(x => x.KorisnikId).ToList();

        //    List<OcjeneSekcije> zajednickeocjene1 = new List<OcjeneSekcije>();
        //    List<OcjeneSekcije> zajednickeocjene2 = new List<OcjeneSekcije>();
        //    List<Model.Sekcije> preporuceneSekcije = new List<Model.Sekcije>();

        //    foreach (var s in _sekcije)
        //    {
        //        foreach (var o in ocjenePosmatraneSekcije)
        //        {
        //            if(s.Value.Where(x=> x.KorisnikId == o.KorisnikId).Count() > 0)
        //            {
        //                zajednickeocjene1.Add(o);
        //                zajednickeocjene2.Add(s.Value.Where(x => x.KorisnikId == o.KorisnikId).First());
        //            }
        //        }

        //        double slicnost = GetSlicnost(zajednickeocjene1, zajednickeocjene2);

        //        if (slicnost > 0.5)
        //        {
        //            var dbobj = _context.Sekcije.Where(x => x.SekcijaId == s.Key);
        //            var mobj = _mapper.Map<Model.Sekcije>(dbobj);

        //            preporuceneSekcije.Add(mobj);
        //        }

        //        //var smodel = _service.GetById(s.Key);
        //        //var sdatabase = _mapper.Map<Database.Sekcije>(smodel);

        //        zajednickeocjene1.Clear();
        //        zajednickeocjene2.Clear();

        //    }

        //    return preporuceneSekcije;
        //}

        //private double GetSlicnost(List<OcjeneSekcije> zajednickeocjene1, List<OcjeneSekcije> zajednickeocjene2)
        //{
        //    if (zajednickeocjene1.Count != zajednickeocjene2.Count)
        //        return 0;

        //    double brojnik = 0, nazivnik1 = 0, nazivnik2 = 0;

        //    for(int i= 0; i < zajednickeocjene1.Count; i++)
        //    {
        //        brojnik = zajednickeocjene1[i].Ocjena * zajednickeocjene2[i].Ocjena;
        //        nazivnik1 = zajednickeocjene1[i].Ocjena * zajednickeocjene2[i].Ocjena;
        //        nazivnik2 = zajednickeocjene2[i].Ocjena * zajednickeocjene2[i].Ocjena;
        //    }

        //    nazivnik1 = Math.Sqrt(nazivnik1);
        //    nazivnik2 = Math.Sqrt(nazivnik2);

        //    double nazivnik = nazivnik1 * nazivnik2;

        //    if (nazivnik == 0)
        //        return 0;
        //    return brojnik / nazivnik;

        //}

        //private void UcitajSekcije(int sekcijaId)
        //{
        //    List<Sekcije> sekcije = _context.Sekcije.Where(x => x.SekcijaId != sekcijaId).ToList();
        //    List<OcjeneSekcije> ocjene;

        //    foreach (var s in sekcije)
        //    {
        //        ocjene = _context.OcjeneSekcije.Where(x => x.SekcijaId == s.SekcijaId).OrderBy(x=> x.KorisnikId).ToList();
        //        if (ocjene.Count > 0)
        //        {
        //            _sekcije.Add(s.SekcijaId, ocjene);
        //        }
        //    }

        //}
    }
}
