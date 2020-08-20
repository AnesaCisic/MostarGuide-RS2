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
    public partial class PreporukaPage : ContentPage
    {
        PreporukaViewModel model = null;
        public PreporukaPage()
        {
            InitializeComponent();
            BindingContext = model = new PreporukaViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Sekcije;
            await Navigation.PushAsync(new SekcijeDetaljiPage(item));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as Sekcije;
            FavoritiViewModel model = new FavoritiViewModel();
            model.sekcija = item;
            await model.Init();
        }
    }
}