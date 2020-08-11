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
    public class IzletiDetaljiViewModel
    {
        private readonly APIService _izleti = new APIService("izlet");
        private readonly APIService _termini = new APIService("termin");

        public IzletiDetaljiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Termini> TerminiList { get; set; } = new ObservableCollection<Termini>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var izleti = await _izleti.Get<IEnumerable<Izleti>>(null);
            var termini = await _izleti.Get<IEnumerable<Izleti>>(null);

            //dodajem termine 
            TerminiList.Clear();
            //foreach (var termin in termini)
            //{
            //    TerminiList.Add(termin);
            //}
        }

    }
}
