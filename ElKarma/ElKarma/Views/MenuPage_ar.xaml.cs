using ElKarma.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElKarma.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage_ar : ContentPage
    {
        MainPage_ar RootPage { get => Application.Current.MainPage as MainPage_ar; }
        List<HomeMenuItem> menuItems;
        public MenuPage_ar()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Home, Title="البث",Icon="watch.png",HasSprator=true },
                new HomeMenuItem {Id = MenuItemType.Satalite, Title="قائمه التردادات",Icon="video.png" ,HasSprator=true },
                new HomeMenuItem {Id = MenuItemType.Contact, Title="الاتصال بنا",Icon="contact.png",HasSprator=true },
                new HomeMenuItem {Id = MenuItemType.About, Title="من نحن",Icon="supports.png",HasSprator=false },
                new HomeMenuItem {Id = MenuItemType.Setting, Title="اللغه",Icon="setting.png",HasSprator=false }
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