
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElKarma.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage_ar : ContentPage
    {
        public AboutPage_ar()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            AboutBar.Text = "من نحن";
        }
    }

}