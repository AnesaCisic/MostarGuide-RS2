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
    public partial class FavoritiPrikazPage : ContentPage
    {
        private readonly APIService _favoriti = new APIService("favorit");
        private readonly APIService _sekcije = new APIService("sekcija");
        FavoritiPrikazViewModel model = null;

        public FavoritiPrikazPage()
        {
            InitializeComponent();
            BindingContext = model = new FavoritiPrikazViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as Favoriti;
            await _favoriti.Delete<Favoriti>(item.FavoritId);
            await DisplayAlert("OK", "Uspješno ste uklonili iz favorita", "OK");
            await Navigation.PushAsync(new FavoritiPrikazPage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as Favoriti;
            Sekcije sekcija = await _sekcije.GetById<Sekcije>(item.SekcijaId);
            await Navigation.PushAsync(new SekcijeDetaljiPage(sekcija));
        }
    }
}