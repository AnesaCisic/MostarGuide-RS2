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
    public class SekcijeViewModel : BaseViewModel
    {
        private readonly APIService _ocjene = new APIService("ocjenasekcija");
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
                var ocjenasekcija = await _ocjene.Get<IEnumerable<OcjeneSekcije>>(new OcjeneSekcijeSearchRequest() { SekcijaId = sekcija.SekcijaId });
                var sum = 0;

                foreach (var os in ocjenasekcija)
                {
                    sum += os.Ocjena;
                }

                if (sum > 0 && ocjenasekcija.Count() > 0)
                {
                    sekcija.Ocjena = sum / ocjenasekcija.Count();

                }

                SekcijeList.Add(sekcija);
            }
        }

    }
}
