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
    public partial class RezervacijaPage : ContentPage
    {
        private RezervacijaViewModel model = null;

        public RezervacijaPage(int izletid)
        {
            InitializeComponent();
            BindingContext = model = new RezervacijaViewModel()
            {
                _izletId = izletid
            };
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (this.Termini.SelectedItem == null)
            {
                terminigreska.Text = "** Morate odabrati termin! **";
                terminigreska.IsVisible = true;

            }
            else
            {
                terminigreska.Text = " ";
                terminigreska.IsVisible = false;
            }

            if (!terminigreska.IsVisible)
            {
                Termini t = this.Termini.SelectedItem as Termini;
                model.TerminID = t.TerminId;
                await model.RezervacijaTask();

                await Navigation.PushAsync(new IzletiPage());
            }
        }

     
    }
}