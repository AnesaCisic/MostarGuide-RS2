using System;
using System.Collections.Generic;
using System.Text;

namespace MostarGuide.MobileApp.ViewModels
{
    public class SekcijeViewModel
    {
        private readonly APIService _sekcije = new APIService("sekcija");
        private readonly APIService _kategorije = new APIService("kategorija");

        public SekcijeViewModel()
        {

        }



    }
}
