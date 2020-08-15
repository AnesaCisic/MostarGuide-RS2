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
    public partial class IzletiDetaljiPage : ContentPage
    {
        private IzletiDetaljiViewModel model = null;
        int _izletId = 0;

        public IzletiDetaljiPage(Izleti izlet)
        {
            InitializeComponent();
            BindingContext = model = new IzletiDetaljiViewModel()
            {
                Izlet = izlet
            };
            _izletId = izlet.IzletId;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RezervacijaPage(_izletId));
        }
    }
}