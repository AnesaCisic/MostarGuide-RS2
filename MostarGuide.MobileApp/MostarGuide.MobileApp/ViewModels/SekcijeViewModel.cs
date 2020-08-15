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
    public class SekcijeViewModel : BaseViewModel
    {
        private readonly APIService _sekcije = new APIService("sekcija");
        public Kategorije Kategorija { get; set; }

        public SekcijeViewModel()
        {
            //Title = "Kategorija.Naziv";
            InitCommand = new Command(async () => await Init());

        }

        public ObservableCollection<Sekcije> SekcijeList { get; set; } = new ObservableCollection<Sekcije>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var list = await _sekcije.Get<IEnumerable<Sekcije>>(new SekcijeSearchRequest() { KategorijaId = Kategorija.KategorijaId});
            SekcijeList.Clear();

            foreach (var sekcija in list)
            {
                SekcijeList.Add(sekcija);
            }
        }

    }
}
