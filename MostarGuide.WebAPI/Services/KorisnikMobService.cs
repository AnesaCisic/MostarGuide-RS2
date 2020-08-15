using AutoMapper;
using MostarGuide.Model.Requests;
using MostarGuide.WebAPI.Database;
using MostarGuide.WebAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Services
{
    public class KorisnikMobService : BaseCRUDService<Model.KorisniciMob, KorisniciMobSearchRequest, Database.KorisniciMob, KorisniciMobUpsertRequest, KorisniciMobUpsertRequest>, ICRUDService<Model.KorisniciMob, KorisniciMobSearchRequest, KorisniciMobUpsertRequest, KorisniciMobUpsertRequest>
    {
        public KorisnikMobService(MostarGuideContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.KorisniciMob> Get(KorisniciMobSearchRequest search)
        {
            var query = _context.KorisniciMob.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Ime.ToLower().StartsWith(search.Ime.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Prezime.ToLower().StartsWith(search.Prezime.ToLower()));

            }
            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                query = query.Where(x => x.KorisnickoIme == search.KorisnickoIme);

            }

            var list = query.ToList();
            return _mapper.Map<List<Model.KorisniciMob>>(list);
        }

        public override Model.KorisniciMob Insert(KorisniciMobUpsertRequest request)
        {
            var entity = _mapper.Map<Database.KorisniciMob>(request);

            if (request.Password != request.PasswordConfirmation)
            {
                throw new UserException("Passwordi se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.KorisniciMob.Add(entity);
            _context.SaveChanges();

            //var rezultat = new Model.KorisniciMob();
            //rezultat.Ime = entity.Ime;
            //rezultat.Prezime = entity.Prezime;
            //rezultat.KorisnikId = entity.KorisnikId;
            //rezultat.Email = entity.Email;
            //rezultat.BrojTelefona = entity.BrojTelefona;
            //rezultat.KorisnickoIme = entity.KorisnickoIme;

            //return rezultat;

            return _mapper.Map<Model.KorisniciMob>(entity);
        }

        public override Model.KorisniciMob Update(int id, KorisniciMobUpsertRequest request)
        {
            var entity = _context.KorisniciMob.Find(id);
            _context.KorisniciMob.Attach(entity);
            _context.KorisniciMob.Update(entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new UserException("Passwordi se ne slažu");
                }

                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.KorisniciMob>(entity);
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

    }
}
