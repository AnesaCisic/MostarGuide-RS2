using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MostarGuide.Model;
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
    public class LoginService : ILoginService
    {
        private readonly MostarGuideContext _context;
        private readonly IMapper _mapper;

        public LoginService(MostarGuideContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public KorisnikLogin Authenticiraj(string username, string pass)
        {
            var user = _context.Korisnici.Include("KorisniciUloge.Uloga").FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, pass);

                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.KorisnikLogin>(user);
                }
            }
            return null;
        }

        public KorisnikLogin AuthenticirajKorisnikMob(string username, string pass)
        {
            var user = _context.KorisniciMob.Where(x => x.KorisnickoIme == username).FirstOrDefault();

            if (user != null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, pass);

                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.KorisnikLogin>(user);
                }
            }
            return null;
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

        public bool ProvjeriKorisnika(string username)
        {
            bool Provjera = false;

            Database.Korisnici korisnik = null;
            korisnik = _context.Korisnici.Where(x => x.KorisnickoIme == username).FirstOrDefault();

            if (korisnik != null)
            {
                Provjera = true;
            }

            return Provjera;
        }
    }
}
