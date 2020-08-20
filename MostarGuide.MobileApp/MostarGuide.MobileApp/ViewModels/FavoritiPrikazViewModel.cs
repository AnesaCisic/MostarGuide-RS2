using MostarGuide.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MostarGuide.MobileApp.ViewModels
{
    public class FavoritiPrikazViewModel : BaseViewModel
    {
        private readonly APIService _favoriti = new APIService("favorit");
        private readonly APIService _korisnici = new APIService("korisnikmob");
        private readonly APIService _sekcije = new APIService("sekcija");
        public ICommand InitCommand { get; set; }
        public ObservableCollection<Favoriti> FavoritiList { get; set; } = new ObservableCollection<Favoriti>();

        public FavoritiPrikazViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public async Task Init()
        {
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

            var favoriti = await _favoriti.Get<IEnumerable<Favoriti>>(null);
            FavoritiList.Clear();
            foreach (var favorit in favoriti)
            {
                if (favorit.KorisnikId == korisnik.KorisnikId)
                {
                    var s = await _sekcije.GetById<Sekcije>(favorit.SekcijaId);
                    favorit.Sekcija = s.Naziv;

                    FavoritiList.Add(favorit);
                }
            }
        }
    }
}
