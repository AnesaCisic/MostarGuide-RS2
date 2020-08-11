using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
    public class KorisniciService : IKorisniciService
    {
        private readonly MostarGuideContext _context;
        private readonly IMapper _mapper;
        public KorisniciService(MostarGuideContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Korisnici> Get(KorisniciSearchRequest request)
        {
            var query = _context.Korisnici.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.ToLower().StartsWith(request.Ime.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.ToLower().StartsWith(request.Prezime.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(request?.KorisnickoIme))
            {
                query = query.Where(x => x.KorisnickoIme == request.KorisnickoIme);

            }

            var list = query.ToList();
            return _mapper.Map<List<Model.Korisnici>>(list);
        }

        public Model.Korisnici GetById(int id)
        {
            var entity = _context.Korisnici.Find(id);

            return _mapper.Map<Model.Korisnici>(entity); //pretvara database obj u model obj
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf); //generise random broj
            return Convert.ToBase64String(buf); //zna pretvoriti bajte u string koji je citljiv iz browsera,pajtona...
        }

        public static string GenerateHash(string salt, string password) //kombinuje salt i password u hash
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

        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnici>(request);

            if (request.Password != request.PasswordConfirmation)
            {
                throw new UserException("Passwordi se ne slazu!");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.Korisnici.Add(entity);
            _context.SaveChanges();

            //kada je many to many veza 
            foreach(var uloga in request.Uloge)
            {
                _context.KorisniciUloge.Add(new KorisniciUloge()
                {
                    DatumIzmjene = DateTime.Now,
                    KorisnikId = entity.KorisnikId,
                    UlogaId = uloga
                });
            }

            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Update(int id, KorisniciInsertRequest request)
        {
            var entity = _context.Korisnici.Find(id);
            _context.Korisnici.Attach(entity);
            _context.Korisnici.Update(entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new Exception("Passwordi se ne slažu");
                }

                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Authenticiraj(string username, string pass)
        {
            //provjerravamo da li imamo usera u bazi
            var user = _context.Korisnici.Include("KorisniciUloge.Uloga").FirstOrDefault(x => x.KorisnickoIme == username);

            //ako ga nadjemo provjeravamo pasvorde, ako ne vracamo null
            if (user != null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, pass);

                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Korisnici>(user);
                }
            }

            return null;
        }
    }
}
