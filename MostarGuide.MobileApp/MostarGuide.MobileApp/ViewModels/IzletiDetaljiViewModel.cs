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
    public class IzletiDetaljiViewModel : BaseViewModel
    {
        private readonly APIService _termini = new APIService("termin");
        private readonly APIService _rezervacije = new APIService("rezervacija");

        public Izleti Izlet { get; set; }

        public IzletiDetaljiViewModel()
        {
            InitCommand = new Command(async () => await Init());
            Title = "Prikaz izleta";
        }
        public ObservableCollection<Termini> TerminiList { get; set; } = new ObservableCollection<Termini>();

        public ICommand InitCommand { get; set; }
        //public ICommand ProvjeraSlobodnihMjestaCommand { get; set; }
        
        public async Task Init()
        {
            
            var termini = await _termini.Get<IEnumerable<Termini>>(new TerminiSearchRequest() { IzletId = Izlet.IzletId });

            termini = termini.Where(x => x.VrijemeTermina.Date >= DateTime.Now.Date.AddDays(2)).OrderBy(x => x.VrijemeTermina).Take(3);

            TerminiList.Clear();
            foreach (var termin in termini)
            {
                TerminiList.Add(termin);
            }
        }

        public async Task ProvjeraSlobodnihMjesta()
        {
            var rezervacije = await _rezervacije.Get<IEnumerable<Rezervacije>>(new RezervacijeSearchRequest() { TerminId = _terminId });

            int brojOsobaRezervacije = 0;

            foreach (var r in rezervacije)
            {
                brojOsobaRezervacije += r.BrojOsoba;
            }

            _brojSlobodnihMjesta = Izlet.BrojMjesta - brojOsobaRezervacije;
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

    }
}
