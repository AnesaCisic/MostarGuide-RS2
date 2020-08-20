using MostarGuide.MobileApp.Views;
using MostarGuide.Model;
using MostarGuide.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MostarGuide.MobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("sekcija");
        private readonly APIService _serviceLogin = new APIService("korisnikmob");

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
            
        }

        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }
        KorisniciMob k;

        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            try
            {

                var list = await _serviceLogin.Get<List<KorisniciMob>>(new KorisniciMobSearchRequest { KorisnickoIme = APIService.Username });
                foreach (var korisnik in list)
                {
                    if (korisnik.KorisnickoIme == APIService.Username)
                    {
                        k = korisnik;
                        APIService.korisnik = korisnik;
                    }
                }

                if(list.Count > 0)
                {
                    Application.Current.MainPage = new MainPage();
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Mostar Guide", "Neispravni podaci!", "OK");
                    Application.Current.MainPage = new LoginPage();
                }

            }

            catch (Exception)
            {
                await Application.Current.MainPage.DisplayAlert("Mostar Guide", "Pogresno korisnicko ime ili password!", "OK");
                Application.Current.MainPage = new LoginPage();
            }
        }
    }
}
