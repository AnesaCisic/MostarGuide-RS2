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
        private readonly APIService _termini = new APIService("termin");
        private readonly APIService _izleti = new APIService("izlet");

        public KorisniciMob _korisnik { get; set; }

        public MojeRezervacijeViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Rezervacije> RezervacijeList { get; set; } = new ObservableCollection<Rezervacije>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
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

            var list = await _rezervacije.Get<IEnumerable<Rezervacije>>(new RezervacijeSearchRequest(){ KorisnikId = _korisnik.KorisnikId });
            RezervacijeList.Clear();
            foreach (var rez in list)
            {
                var t = await _termini.GetById<Termini>(rez.TerminId);
                var i = await _izleti.GetById<Izleti>(t.IzletId);

                rez.Izlet = i.Naziv;
                RezervacijeList.Add(rez);
            }

        }

    }
}
