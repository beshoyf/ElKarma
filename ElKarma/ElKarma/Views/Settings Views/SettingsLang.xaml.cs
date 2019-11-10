using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ElKarma.Shared;
namespace ElKarma.Views.Settings_Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SettingsLang : ContentPage
	{
		public SettingsLang ()
		{
			InitializeComponent ();
            if (Global.Lang =="e")
            {
                english.IsVisible = true;
                arabic.IsVisible = false;
                header.Text = "Chnge Language";
            }
            else
            {
                english.IsVisible = false;
                arabic.IsVisible = true;
                header.Text = "أختيار اللغه";
            }
		}

        private void EnglishRecognizer_Tapped(object sender, EventArgs e)
        {
            if (Global.Lang == "e")
            {
                Navigation.PopAsync();
            }
            else
            {
                Global.Lang = "e";
                Application.Current.MainPage = new MainPage();
            } 
        }
        private void ArabicRecognizer_Tapped(object sender, EventArgs e)
        {
            if (Global.Lang == "a")
            {
                Navigation.PopAsync();
            }
            else
            {
                Global.Lang = "a";
                Application.Current.MainPage = new MainPage_ar();
            }
        }
    }
}