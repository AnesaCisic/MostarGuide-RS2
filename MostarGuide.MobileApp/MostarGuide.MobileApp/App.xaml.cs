using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MostarGuide.MobileApp.Services;
using MostarGuide.MobileApp.Views;

namespace MostarGuide.MobileApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
            //MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
