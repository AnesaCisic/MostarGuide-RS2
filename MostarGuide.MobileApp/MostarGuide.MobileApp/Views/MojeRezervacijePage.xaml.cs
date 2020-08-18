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
    public partial class MojeRezervacijePage : ContentPage
    {

        private MojeRezervacijeViewModel model = null;

        public MojeRezervacijePage()
        {
            InitializeComponent();
            BindingContext = model = new MojeRezervacijeViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Rezervacije;
            await Navigation.PushAsync(new PlacanjePage(item));
        }
    }
}