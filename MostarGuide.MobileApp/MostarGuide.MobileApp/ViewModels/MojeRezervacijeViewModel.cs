using MostarGuide.Model;
using MostarGuide.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MostarGuide.MobileApp.ViewModels
{
    public class MojeRezervacijeViewModel : BaseViewModel
    {
        private readonly APIService _korisnici = new APIService("korisnikmob");
        private readonly APIService _rezervacije = new APIService("rezervacija");
        public KorisniciMob _korisnik { get; set; }


        public MojeRezervacijeViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Rezervacije> RezervacijeList { get; set; } = new ObservableCollection<Rezervacije>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            //trazim korisnika
            var korisnickoIme = APIService.Username;
            List<KorisniciMob> listKorisnici = await _korisnici.Get<List<KorisniciMob>>(null);
            foreach (var k in listKorisnici)
            {
                if (k.KorisnickoIme == korisnickoIme)
                {
                    _korisnik = k;
                    break;
                }
            }

            //lista rezervacija za korisnika
            var list = await _rezervacije.Get<IEnumerable<Rezervacije>>(new RezervacijeSearchRequest(){ KorisnikId = _korisnik.KorisnikId });
            RezervacijeList.Clear();
            foreach (var rez in list)
            {
                RezervacijeList.Add(rez);
            }
        }

    }
}
