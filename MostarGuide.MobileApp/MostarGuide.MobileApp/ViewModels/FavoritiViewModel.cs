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
    public class FavoritiViewModel : BaseViewModel
    {
        private readonly APIService _favoriti= new APIService("favorit");
        private readonly APIService _korisnici = new APIService("korisnikmob");
        public Sekcije sekcija{ get; set; }
        public ICommand InitCommand { get; set; }

        public FavoritiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public async Task Init()
        {
            var favoriti = await _favoriti.Get<List<Favoriti>>(null);
            KorisniciMob korisnik = new KorisniciMob();
            var username = APIService.Username;
            List<KorisniciMob> korisnici = await _korisnici.Get<List<KorisniciMob>>(null);

            foreach (var k in korisnici)
            {
                if (k.KorisnickoIme == username)
                {
                    korisnik = k;
                    break;
                }
            }

            foreach (var f in favoriti)
            {
                if (f.SekcijaId == sekcija.SekcijaId && f.KorisnikId == korisnik.KorisnikId)
                {
                    await Application.Current.MainPage.DisplayAlert("Poruka", "Ovo mjesto imate već u favoritima!", "OK");
                }
            }
           
            FavoritiUpsertRequest request = new FavoritiUpsertRequest();
            request.KorisnikId = korisnik.KorisnikId;
            request.SekcijaId = sekcija.SekcijaId;
            await _favoriti.Insert<Favoriti>(request);
            await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno spašeno u favorite!", "OK");
        }
    }
}
