using System;
using System.Collections.Generic;
using System.Text;

namespace MostarGuide.MobileApp.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Izleti,
        Kategorije,
        Rezervacije,
        Favoriti,
        Preporuke,
        Odjava

    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
