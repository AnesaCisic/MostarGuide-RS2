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
    public partial class RegistracijaPage : ContentPage
    {
        RegistracijaViewModel vm = null;
        public RegistracijaPage()
        {
            InitializeComponent();
            BindingContext = vm = new RegistracijaViewModel();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.Ime.Text, @"^[a-zA-Z]+$") && this.Ime.Text.Length < 3)
            {
                Imegreska.Text = "** Ime se sastoji samo od slova i mora da sadrzi minimalno 3 karaktera **";
                Imegreska.IsVisible = true;
            }
            else
            {
                Imegreska.Text = " ";
                Imegreska.IsVisible = false;
            }

            if (!Regex.IsMatch(this.Prezime.Text, @"^[a-zA-Z]+$") && this.Prezime.Text.Length < 3)
            {
                Prezimegreska.Text = "** Prezime se sastoji samo od slova i mora da sadrzi minimalno 3 karaktera **";
                Prezimegreska.IsVisible = true;
            }
            else
            {
                Prezimegreska.Text = " ";
                Prezimegreska.IsVisible = false;
            }

            if (!Regex.IsMatch(this.Telefon.Text, @"^?\(?\d{3}?\)??-??\(?\d{3}?\)??-??\(?\d{3,}?\)??-?$"))
            {
                telefongreska.Text = "** Ovo polje mora biti u formatu (036) 576 - 678 ili 123 - 456 - 7890 ili 045678543 **";
                telefongreska.IsVisible = true;
            }
            else
            {
                telefongreska.Text = " ";
                telefongreska.IsVisible = false;
            }

            if (!Regex.IsMatch(this.Email.Text, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"))
            {
                emailgreska.Text = "** Pravilan format example @example.com  **";
                emailgreska.IsVisible = true;
            }
            else
            {
                emailgreska.Text = "";
                emailgreska.IsVisible = false;
            }

            if (this.KorisnickoIme.Text.Length < 4)
            {
                korisnickoimegreska.Text = "** Korisnicko ima mora imati vise od 4 karaktera!  **";
                korisnickoimegreska.IsVisible = true;
            }
            else
            {
                korisnickoimegreska.Text = "";
                korisnickoimegreska.IsVisible = false;
            }

            if (string.IsNullOrWhiteSpace(this.Lozinka.Text))
            {
                lozinkagreska.Text = "** Morate unijeti lozinku! **";
                lozinkagreska.IsVisible = true;
            }
            else
            {
                lozinkagreska.Text = "";
                lozinkagreska.IsVisible = false;
            }

            if (this.Lozinka.Text != this.PotvrdaLozinke.Text)
            {
                Lozinkapotvrdagreska.Text = "** Lozinke moraju biti iste! **";
                Lozinkapotvrdagreska.IsVisible = true;
            }
            else
            {
                Lozinkapotvrdagreska.Text = "";
                Lozinkapotvrdagreska.IsVisible = false;
            }

            if (this.Lozinka.Text.Length < 5)
            {
                lozinkagreska.Text = "** Lozinka ne smije biti kraća od 5 karaktera! **";
                lozinkagreska.IsVisible = true;
            }
            else
            {
                lozinkagreska.Text = "";
                lozinkagreska.IsVisible = false;
            }

            if (!lozinkagreska.IsVisible && !Lozinkapotvrdagreska.IsVisible && !korisnickoimegreska.IsVisible
                    && !emailgreska.IsVisible && !telefongreska.IsVisible && !Prezimegreska.IsVisible && !Imegreska.IsVisible)
            {

                vm.Ime = this.Ime.Text;
                vm.Prezime = this.Prezime.Text;
                vm.Telefon = this.Telefon.Text;
                vm.Email = this.Email.Text;
                vm.KorisnickoIme = this.KorisnickoIme.Text;
                vm.Lozinka = this.Lozinka.Text;
                vm.PotvrdaLozinke = this.PotvrdaLozinke.Text;

                await vm.Registration(); // error
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginPage();
        }

    }
}