using MostarGuide.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MostarGuide.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OcjenjivanjePage : ContentPage
    {
        private OcjeneViewModel model = null;

        public OcjenjivanjePage(int izletid)
        {
            InitializeComponent();
            BindingContext = model = new OcjeneViewModel()
            {
                _izletId = izletid
            };
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.ocjena.Text, @"^[1-5]+$"))
            {
                await DisplayAlert("Greška", "Ocjene su u rangu 1-5", "OK");
            }
            else
            {
                await model.Ocijeni();
                await Navigation.PopToRootAsync();
            }
            
        }
    }
}