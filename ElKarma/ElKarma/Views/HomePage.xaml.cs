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
		}

        private void Live_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LivePage());
        }

        private void Sattlite_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SatlitePage());
        }

        private void ContactUS_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactUsPage());
        }

        private void AboutUS_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutPage());
        }
    }
}