using MostarGuide.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostarGuide.MobileApp.ViewModels
{
    public class SekcijeDetaljiViewModel : BaseViewModel
    {
        private readonly APIService _ocjene = new APIService("ocjenasekcija");

        public Sekcije Sekcija { get; set; }

        public SekcijeDetaljiViewModel()
        {

        }
    }
}
