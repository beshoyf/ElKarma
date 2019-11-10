using ElKarma.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElKarma.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent ();
            if (Global.Lang == "e")
            {
                Live.Text = "Live";
                Satellite.Text = "Satellite";
                Contact.Text = "Contact Us";
                About.Text = "About Us";
            }
            else
            {
                Live.Text = "البث";
                Satellite.Text = "التردات";
                Contact.Text = "الاتصال بنا";
                About.Text = "من نحن";
                Container.FlowDirection = FlowDirection.RightToLeft;
            }
		}

        private void Live_Tapped(object sender, EventArgs e)
        {
            if (Global.Lang == "e")
            {
                Navigation.PushAsync(new LivePage());
            }
            else
                Navigation.PushAsync(new LivePage_ar());
        }

        private void Sattlite_Tapped(object sender, EventArgs e)
        {
            if (Global.Lang == "e")
            {
                Navigation.PushAsync(new SatlitePage());
            }
            else
                Navigation.PushAsync(new SatlitePage_ar());
        }

        private void ContactUS_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactUsPage());
        }

        private void AboutUS_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutPage());
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (Global.Lang == "e")
            {
                Live.Text = "Live";
                Satellite.Text = "Satellite";
                Contact.Text = "Contact Us";
                About.Text = "About Us";
                Container.FlowDirection = FlowDirection.LeftToRight;
            }
            else
            {
                Live.Text = "البث";
                Satellite.Text = "التردات";
                Contact.Text = "الاتصال بنا";
                About.Text = "من نحن";
                Container.FlowDirection = FlowDirection.RightToLeft;
            }
        }
    }
}