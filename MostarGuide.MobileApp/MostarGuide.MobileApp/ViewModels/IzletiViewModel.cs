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
    public class IzletiViewModel: BaseViewModel
    {
        private readonly APIService _izleti = new APIService("izlet");
        private readonly APIService _ocjene = new APIService("ocjenaizlet");

        public IzletiViewModel()
        {
            InitCommand = new Command(async () => await Init());
            Title = "Izleti";
        }
        public ObservableCollection<Izleti> IzletiList { get; set; } = new ObservableCollection<Izleti>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var list = await _izleti.Get<IEnumerable<Izleti>>(null);

            IzletiList.Clear();
            foreach (var izlet in list)
            {
                var ocjenaizlet = await _ocjene.Get<IEnumerable<OcjeneIzleti>>(new OcjeneIzletiSearchRequest() { IzletId = izlet.IzletId});
                var sum = 0;
                
                foreach (var oi in ocjenaizlet)
                {
                    sum += oi.Ocjena;
                }

                if(sum > 0 && ocjenaizlet.Count() > 0)
                {
                    izlet.Ocjena = sum / ocjenaizlet.Count();

                }
                

                IzletiList.Add(izlet);
            }
        }

      

    }
}
