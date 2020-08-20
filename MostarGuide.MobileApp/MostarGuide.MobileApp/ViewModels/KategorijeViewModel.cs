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
    public class KategorijeViewModel
    {
        private readonly APIService _kategorije = new APIService("kategorija");

        public KategorijeViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Kategorije> KategorijeList { get; set; } = new ObservableCollection<Kategorije>();
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var list = await _kategorije.Get<IEnumerable<Kategorije>>(null);
            KategorijeList.Clear();
            foreach (var k in list)
            {
                KategorijeList.Add(k);
            }
        }

    }
}
