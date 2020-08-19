using MostarGuide.MobileApp.ViewModels;
using MostarGuide.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MostarGuide.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SekcijeDetaljiPage : ContentPage
    {
        private SekcijeDetaljiViewModel model = null;
        int _sekcijaId = 0;


        public SekcijeDetaljiPage(Sekcije sekcija)
        {
            InitializeComponent();
            BindingContext = model = new SekcijeDetaljiViewModel()
            {
                Sekcija = sekcija
            };
            _sekcijaId = sekcija.SekcijaId;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OcjenjivanjeSekcijaPage(_sekcijaId));

        }
    }
}