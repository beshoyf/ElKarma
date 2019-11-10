using ElKarma.Models;
using ElKarma.Shared;
using ElKarma.Views.Settings_Views;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElKarma.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage_ar : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage_ar()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Default;
           
            MenuPages.Add((int)MenuItemType.Home, (NavigationPage)Detail);
        }

        public  void NavigateFromMenu(int id)
        {
            switch (id)
            {
                case (int)MenuItemType.Home:
                     Detail.Navigation.PushAsync((Page)Activator.CreateInstance(typeof(LivePage_ar)));
                    break;
                case (int)MenuItemType.About:
                     Detail.Navigation.PushAsync((Page)Activator.CreateInstance(typeof(AboutPage)));
                    break;
                case (int)MenuItemType.Contact:
                     Detail.Navigation.PushAsync((Page)Activator.CreateInstance(typeof(ContactUsPage)));
                    break;
                case (int)MenuItemType.Satalite:
                     Detail.Navigation.PushAsync((Page)Activator.CreateInstance(typeof(SatlitePage_ar)));
                    break;
                case (int)MenuItemType.Setting:
                     Detail.Navigation.PushAsync((Page)Activator.CreateInstance(typeof(SettingsLang)));
                    break;
            }
            //if (Device.RuntimePlatform == Device.Android)
            //       await Task.Delay(50);

                  IsPresented = false;

                ///////////////////////////////////////////////
                //if (!MenuPages.ContainsKey(id))
                //{
                //    switch (id)
                //    {
                //        case (int)MenuItemType.Home:
                //            MenuPages.Add(id, new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage))) { BarBackgroundColor = Color.FromHex("910319") });
                //            break;
                //        case (int)MenuItemType.About:
                //            MenuPages.Add(id, new NavigationPage((Page)Activator.CreateInstance(typeof(AboutPage))) { BarBackgroundColor = Color.FromHex("910319") });
                //            break;
                //        case (int)MenuItemType.Contact:
                //            MenuPages.Add(id, new NavigationPage((Page)Activator.CreateInstance(typeof(ContactUsPage))) { BarBackgroundColor = Color.FromHex("910319") });
                //            break;
                //        case (int)MenuItemType.Satalite:
                //            MenuPages.Add(id, new NavigationPage((Page)Activator.CreateInstance(typeof(SatlitePage))) { BarBackgroundColor = Color.FromHex("910319") });
                //            break;
                //    }
                //}

                //var newPage = MenuPages[id];

                //if (newPage != null && Detail != newPage)
                //{
                //    Detail = newPage;

                //    if (Device.RuntimePlatform == Device.Android)
                //        await Task.Delay(100);

                //    IsPresented = false;
                //}
        }
    }
}