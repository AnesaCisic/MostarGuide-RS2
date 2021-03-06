﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MostarGuide.MobileApp.Models;

namespace MostarGuide.MobileApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.Izleti:
                        MenuPages.Add(id, new NavigationPage(new IzletiPage()));
                        break;
                    case (int)MenuItemType.Kategorije:
                        MenuPages.Add(id, new NavigationPage(new KategorijePage()));
                        break;
                    case (int)MenuItemType.Rezervacije:
                        MenuPages.Add(id, new NavigationPage(new MojeRezervacijePage()));
                        break;
                    case (int)MenuItemType.Favoriti:
                        MenuPages.Add(id, new NavigationPage(new FavoritiPrikazPage()));
                        break;
                    case (int)MenuItemType.Preporuke:
                        MenuPages.Add(id, new NavigationPage(new PreporukaPage()));
                        break;
                    case (int)MenuItemType.Odjava:
                        MenuPages.Add(id, new NavigationPage(new OdjavaPage()));
                        break;
                }

            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}