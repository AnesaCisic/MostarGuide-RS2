using MostarGuide.MobileApp.ViewModels;
using MostarGuide.Model;
using Stripe;
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
    public partial class PlacanjePage : ContentPage
    {
        
        private readonly APIService _rezervacije = new APIService("rezervacija");

        int _rezervacijaId = 0;

        public PlacanjePage(Rezervacije rezervacija)
        {
            InitializeComponent();
            _rezervacijaId = rezervacija.RezervacijaId;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
        }

        private async void btn_Clicked(object sender, EventArgs e)
        {
            var rezervacija = await _rezervacije.GetById<Rezervacije>(_rezervacijaId);

            StripeConfiguration.ApiKey = "sk_test_51GwzwECMfSWm2wuKdY0WobeCmk8znyb7KbhEA22EYmoXz8KbZB0KrqiTBFH8e8f9IoHzMvdU5l9syGPbaQLmJ81r00agCcQ51v";
            Token stripeToken = null;

            try
            {
                var tokenOprions = new TokenCreateOptions()
                {
                    Card = new CreditCardOptions()
                    {
                        Number = CreditCardNumber.Text,
                        ExpMonth = Convert.ToInt64(CreditCardExpMonth.Text),
                        ExpYear = Convert.ToInt64(CreditCardExpYear.Text),
                        Cvc = CreditCardSecurityCode.Text
                    }
                };

                var tokenService = new TokenService();
                stripeToken = tokenService.Create(tokenOprions);

                var customer = new CustomerCreateOptions
                {
                    Description = "Naplata za kupca",
                    Name = APIService.Username,
                    Source = stripeToken.Id
                };
                var customerService = new CustomerService();
                var customerResponse = customerService.Create(customer);

                // `source` is obtained with Stripe.js; see https://stripe.com/docs/payments/accept-a-payment-charges#web-create-token
                var options = new ChargeCreateOptions
                {
                    Amount = (long)rezervacija.UkupanIznos * 100,
                    Currency = "BAM",
                    Customer = customerResponse.Id,
                    Description = "Nova uplata",
                };

                var service = new ChargeService();
                service.Create(options);

                await DisplayAlert("Obavijest", "Uspješno ste kupili kartu!", "OK");

                await Navigation.PopToRootAsync();

            }
            catch (Exception ex)
            {
                await DisplayAlert("Greška!", "Niste unijeli tačne podatke", "OK");
            }
        }
    }
}