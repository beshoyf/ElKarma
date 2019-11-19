using ElKarma.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElKarma.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Home, Title="Live",Icon="watch.png",HasSprator=true },
                new HomeMenuItem {Id = MenuItemType.Satalite, Title="Satellite Coverage",Icon="video.png" ,HasSprator=true },
                new HomeMenuItem {Id = MenuItemType.Contact, Title="Contact Us",Icon="contact.png",HasSprator=true },
                new HomeMenuItem {Id = MenuItemType.About, Title="About Us",Icon="supports.png",HasSprator=false },
                new HomeMenuItem {Id = MenuItemType.Setting, Title="Change language",Icon="setting.png",HasSprator=false }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected +=  (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
 
                 RootPage.NavigateFromMenu(id);
            };
        }
    }
}