using MostarGuide.Model;
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
    public partial class IzletiDetaljiPage : ContentPage
    {
        public IzletiDetaljiPage(Izleti i)
        {
            InitializeComponent();
        }
    }
}