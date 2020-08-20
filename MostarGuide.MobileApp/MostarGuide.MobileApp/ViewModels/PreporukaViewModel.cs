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
    public class PreporukaViewModel : BaseViewModel
    {

        private readonly APIService _preporuke = new APIService("preporuka");
        private readonly APIService _korisnici = new APIService("korisnikmob");

        public ObservableCollection<Sekcije> SekcijeList { get; set; } = new ObservableCollection<Sekcije>();

        public PreporukaViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }

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

            var preporuke = await _preporuke.GetById<List<Sekcije>>(korisnik.KorisnikId);
            SekcijeList.Clear();

            foreach (var item in preporuke)
            {
                SekcijeList.Add(item);
            }
        }
    }
}
