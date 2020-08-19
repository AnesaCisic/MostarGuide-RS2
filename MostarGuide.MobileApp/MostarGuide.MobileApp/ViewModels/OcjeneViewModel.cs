using MostarGuide.Model;
using MostarGuide.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MostarGuide.MobileApp.ViewModels
{
    public class OcjeneViewModel : BaseViewModel
    {
        private readonly APIService _ocjene = new APIService("ocjenaizlet");
        private readonly APIService _korisnici = new APIService("korisnikmob");
        public int _izletId { get; set; }
        public KorisniciMob Korisnik { get; set; }

        public OcjeneViewModel()
        {
            PovecajOcjenuCommand = new Command( () => Ocjena += 1 );
        }

        public ICommand PovecajOcjenuCommand { get; set; }

        public async Task Ocijeni()
        {
            var korisnickoIme = APIService.Username;
            List<KorisniciMob> listKorisnici = await _korisnici.Get<List<KorisniciMob>>(null);
            foreach (var k in listKorisnici)
            {
                if (k.KorisnickoIme == korisnickoIme)
                {
                    Korisnik = k;
                    break;
                }
            }

            await _ocjene.Insert<OcjeneIzleti>(new OcjeneIzletiUpsertRequest()
            {
                KorisnikId = Korisnik.KorisnikId,
                IzletId = _izletId,
                Datum = DateTime.Now,
                Ocjena = _ocjena
            });
        }

        int _ocjena;
        public int Ocjena
        {
            get { return _ocjena; }
            set { SetProperty(ref _ocjena, value); }
        }

    }
}
