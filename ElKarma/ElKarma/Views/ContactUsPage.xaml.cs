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
	public partial class ContactUsPage : ContentPage
	{
		public ContactUsPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var lang = Global.Lang;
            if (lang != "e")
            {
                Tel.Text = "تليفون : +1 714-709-4300";
                Fax.Text = "فاكس : +1 925-226-4034";
                Mail.Text = "الايميل : info@alkarmatv.com";
                Poastal.Text = "بريد :P.O.BX 3610 Seal Beach,CA 90740";
                Sattlitebar.Text = "الاتصال بنا";
            }
            else
            {
                Sattlitebar.Text = "Contact Us";
            }
        }
    }
}