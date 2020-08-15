using MostarGuide.Model;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MostarGuide.MobileApp
{
    public class KorisnikAPIService
    {
        private readonly string _route;

#if DEBUG
        private string _apiUrl = "http://localhost:64533/api";
#endif
#if RELEASE
        private string apiUrl = "https://mywebsite.azure.com/api/";

#endif
        public KorisnikAPIService(string route)
        {
            _route = _route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{_apiUrl}/{_route}";

            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }

                return await url.GetJsonAsync<T>();
            }

            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Zahtjev nije uspio", "OK");
                }
                throw;
            }
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";

            try
            {
                return await url.PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }
                await Application.Current.MainPage.DisplayAlert("Greška", "Zahtjev nije uspio!", "OK");

                return default(T);
            }

        }

    }
}
