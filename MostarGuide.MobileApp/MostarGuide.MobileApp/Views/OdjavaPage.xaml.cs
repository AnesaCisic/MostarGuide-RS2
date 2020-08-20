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
    public partial class OdjavaPage : ContentPage
    {
        public OdjavaPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            App.Current.MainPage = new LoginPage();
        }
    }
}