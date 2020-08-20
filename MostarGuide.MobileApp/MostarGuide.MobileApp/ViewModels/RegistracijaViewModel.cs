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
    class RegistracijaViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("korisnikmob");
        public RegistracijaViewModel()
        {
            RegistrationCommand = new Command(async () => await Registration());
        }
        
        public ICommand RegistrationCommand { get; set; }
       
        public async Task Registration()
        {
            IsBusy = true;

            var korisnici = await _service.Get<List<KorisniciMob>>(new KorisniciMobSearchRequest() { KorisnickoIme = _korisnickoIme });

            if (korisnici.Count == 0)
            {

                await _service.Insert<KorisniciMob>(new KorisniciMobUpsertRequest()
                {
                    Ime = _ime,
                    Prezime = _prezime,
                    BrojTelefona = _telefon,
                    Email = _email,
                    KorisnickoIme = _korisnickoIme,
                    Password = _lozinka,
                    PasswordConfirmation = _potvrdaLozinke
                });

                await Application.Current.MainPage.DisplayAlert("Mostar Guide", "Uspjesno ste se registorvali!", "OK");

                Application.Current.MainPage = new LoginPage();

            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Korisničko ime već postoji", "OK");
                Application.Current.MainPage = new RegistracijaPage();
            }
        }

        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }
        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }

        string _telefon = string.Empty;
        public string Telefon
        {
            get { return _telefon; }
            set { SetProperty(ref _telefon, value); }
        }
        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        string _korisnickoIme = string.Empty;
        public string KorisnickoIme
        {
            get { return _korisnickoIme; }
            set { SetProperty(ref _korisnickoIme, value); }
        }

        string _lozinka = string.Empty;
        public string Lozinka
        {
            get { return _lozinka; }
            set { SetProperty(ref _lozinka, value); }
        }
        string _potvrdaLozinke = string.Empty;
        public string PotvrdaLozinke
        {
            get { return _potvrdaLozinke; }
            set { SetProperty(ref _potvrdaLozinke, value); }
        }
    }
}
