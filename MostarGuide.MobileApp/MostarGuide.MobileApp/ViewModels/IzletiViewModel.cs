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
    public class IzletiViewModel
    {
        private readonly APIService _izleti = new APIService("izlet");
        public IzletiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Izleti> IzletiList { get; set; } = new ObservableCollection<Izleti>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var list = await _izleti.Get<IEnumerable<Izleti>>(null);
            IzletiList.Clear();
            foreach (var izlet in list)
            {
                IzletiList.Add(izlet);
            }
        }
    }
}
