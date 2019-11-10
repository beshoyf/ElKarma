using ElKarma.Shared;
using ElKarma.ViewModels;
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
	public partial class SatlitePage_ar : ContentPage
	{
        SatelliteViewModel vm;
        public SatlitePage_ar ()
		{
			InitializeComponent ();
            vm = new SatelliteViewModel();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var lang = Global.Lang;
            ItemsListView.ItemsSource = vm.GetItems(lang);

            SatPage.FlowDirection = FlowDirection.RightToLeft;
            SatelliteT.Text = "قائمه التردادت";

            //if (viewModel.Items.Count == 0)
            //    viewModel.LoadItemsCommand.Execute(null);
        }
    }
}