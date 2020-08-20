using MostarGuide.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MostarGuide.MobileApp.ViewModels
{
    public class SekcijeDetaljiViewModel : BaseViewModel
    {
        public Sekcije Sekcija { get; set; }

        public SekcijeDetaljiViewModel()
        {

        }

    }
}
