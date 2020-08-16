using LaavorRatingConception;
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

        public SekcijeDetaljiPage(Sekcije sekcija)
        {
            InitializeComponent();
            BindingContext = model = new SekcijeDetaljiViewModel()
            {
                Sekcija = sekcija
            };
        }

      

        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();
        //}
    }
}