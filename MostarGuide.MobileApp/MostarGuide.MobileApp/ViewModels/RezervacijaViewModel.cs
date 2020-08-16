using MostarGuide.Model;
using MostarGuide.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MostarGuide.MobileApp.ViewModels
{
    public class RezervacijaViewModel : BaseViewModel
    {
        private readonly APIService _termini = new APIService("termin");
        private readonly APIService _korisnici = new APIService("korisnikmob");
        private readonly APIService _rezervacije = new APIService("rezervacija");
        private readonly APIService _izleti = new APIService("izlet");
        public int _izletId { get; set; }
        public KorisniciMob _korisnik { get; set; }

        public RezervacijaViewModel()
        {
            InitCommand = new Command(async () => await Init());
            RezervacijaCommand = new Command(async () => await RezervacijaTask());
            PovecajBrojOsobaCommand = new Command( () => BrojOsoba += 1);
        }

        public ObservableCollection<Termini> TerminiList { get; set; } = new ObservableCollection<Termini>();
        public ICommand InitCommand { get; set; }
        public ICommand RezervacijaCommand { get; set; }
        public ICommand PovecajBrojOsobaCommand { get; set; }

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

            var termini = await _termini.Get<IEnumerable<Termini>>(new TerminiSearchRequest() { IzletId = _izletId});

            termini = termini.Where(x => x.VrijemeTermina.Date >= DateTime.Now.Date.AddDays(2)).OrderBy(x => x.VrijemeTermina).Take(3);

            TerminiList.Clear();
            foreach (var termin in termini)
            {
                TerminiList.Add(termin);
            }
        }

        Rezervacije entity = null;

        public async Task RezervacijaTask()
        {
            IsBusy = true;

            await ProvjeraSlobodnihMjesta();

            if (_brojSlobodnihMjesta > 0)
            {
                entity = await _rezervacije.Insert<Rezervacije>(new RezervacijeUpsertRequest()
                {
                    TerminId = _terminId,
                    KorisnikMobId = _korisnik.KorisnikId,
                    BrojOsoba = _brojOsoba,
                    DatumRezervacije = DateTime.Now
                });
                await Application.Current.MainPage.DisplayAlert("Hvala!", "Uspjesno ste rezervisali vasa mjesta za izlet!", "OK");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Žao nam je!", "Sva mjesta za odabrani termin su popunjena!", "Cancel");
            }


        }

        public async Task ProvjeraSlobodnihMjesta()
        {
            var rezervacije = await _rezervacije.Get<IEnumerable<Rezervacije>>(new RezervacijeSearchRequest() { TerminId = _terminId });
            var izlet = await _izleti.GetById<Izleti>(_izletId);

            int brojOsobaRezervacije = 0;

            foreach (var r in rezervacije)
            {
                brojOsobaRezervacije += r.BrojOsoba;
            }

             _brojSlobodnihMjesta = izlet.BrojMjesta - brojOsobaRezervacije;
        }

        int _brojSlobodnihMjesta = 0;
        public int BrojSlobodnihMjesta
        {
            get { return _brojSlobodnihMjesta; }
            set { SetProperty(ref _brojSlobodnihMjesta, value); }
        }


        int _terminId = 0;
        public int TerminID
        {
            get { return _terminId; }
            set { SetProperty(ref _terminId, value); }
        }

        int _brojOsoba = 1;
        public int BrojOsoba
        {
            get { return _brojOsoba; }
            set { SetProperty(ref _brojOsoba, value); }
        }
    }
}
