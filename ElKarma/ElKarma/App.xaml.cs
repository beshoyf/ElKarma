using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ElKarma.Views;
using ElKarma.Shared;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ElKarma
{
    public partial class App : Application
    {
         

        public App()
        {
            InitializeComponent();
            Global.Lang = "e";

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
