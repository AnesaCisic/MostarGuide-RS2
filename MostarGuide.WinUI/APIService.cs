using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MostarGuide.Model;

namespace MostarGuide.WinUI
{
    public class APIService
    {
        //pravimo kao static jer moramo slati prilikom svakog requesta
        public static string Username { get; set; }
        public static string Password{ get; set; }

        private string _route = null;
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            //var result = await $"{Properties.Settings.Default.APIUrl}/{_route}".GetJsonAsync<T>();

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> GetById<T>(object id)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Update<T>(object id, object request)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
        }
    }
}
