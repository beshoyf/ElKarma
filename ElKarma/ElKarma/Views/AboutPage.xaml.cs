using ElKarma.Shared;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElKarma.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var lang = Global.Lang;
            if (lang != "e")
            {
                AboutBar.Text = "من نحن";
            }
            else
            {
                AboutBar.Text = "About Us";
                //lblAbout.Text = "Alkarma TV is an Arabic Christian Channel purposing to fulfill the Great Commission:“Go into all the world and preach the gospel to every creature, making disciples of all nations” Mark 16:15.  \n" +
                //"Our mission is to reach out to all Arabs with the saving message of the Gospel. We believe that through the Living Word and the work of the Holy Spirit, Jesus Christ has changed, and is still every day changing lives, all over the world. \n" +
                //"Alkarma TV is a free satellite channel that broadcasts 24 / 7 from satellites that cover North and South America, the Middle East, North Africa, Australia and Europe.Alkarma can also be watched online on personal computers, smartphones, and IPTV Systems." +
                //"“Him we preach, warning every man and teaching every man in all wisdom, that we may present every man perfect in Christ Jesus”. Colossians 1:28";
            }
        }
    }

}