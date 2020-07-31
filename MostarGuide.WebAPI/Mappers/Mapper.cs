using AutoMapper;
using MostarGuide.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnici, Model.Korisnici>();
            CreateMap<Database.Korisnici, KorisniciInsertRequest>().ReverseMap();

            CreateMap<Database.Izleti, Model.Izleti>().ReverseMap();
            CreateMap<Database.Izleti, IzletiUpsertRequest>().ReverseMap();

            CreateMap<Database.Termini, Model.Termini>().ReverseMap();
            CreateMap<Database.Termini, TerminiUpsertRequest>().ReverseMap();

            CreateMap<Database.Kategorije, Model.Kategorije>().ReverseMap();

            CreateMap<Database.Sekcije, Model.Sekcije>().ReverseMap();
            CreateMap<Database.Sekcije, SekcijeUpsertRequest>().ReverseMap();

            CreateMap<Database.Rezervacije, Model.Rezervacije>().ReverseMap();
            CreateMap<Database.Rezervacije, RezervacijeUpsertRequest>().ReverseMap();

            CreateMap<Database.KorisniciMob, Model.KorisniciMob>().ReverseMap();
            CreateMap<Database.KorisniciMob, KorisniciMobUpsertRequest>().ReverseMap();
        }

    }
}
