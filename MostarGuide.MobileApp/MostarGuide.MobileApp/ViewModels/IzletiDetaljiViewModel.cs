using MostarGuide.Model;
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
        public Izleti Izlet { get; set; }

        public IzletiDetaljiViewModel()
        {
            InitCommand = new Command(async () => await Init());
            Title = "Prikaz izleta";
        }
        public ObservableCollection<Termini> TerminiList { get; set; } = new ObservableCollection<Termini>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var request = new Model.Requests.TerminiSearchRequest
            {
                IzletId = Izlet.IzletId
            };

            var termini = await _termini.Get<IEnumerable<Termini>>(request);

            termini = termini.Where(x => x.VrijemeTermina.Date >= DateTime.Now.Date.AddDays(2)).OrderBy(x => x.VrijemeTermina).Take(3);

            TerminiList.Clear();
            foreach (var termin in termini)
            {
                TerminiList.Add(termin);
            }
        }

    }
}
