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
	public partial class SatlitePage : ContentPage
	{
        SatelliteViewModel vm;
        public SatlitePage ()
		{
			InitializeComponent ();
            vm = new SatelliteViewModel();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ItemsListView.ItemsSource = vm.GetItems();
            SatelliteT.Text = "Satellite Coverage";
            //if (viewModel.Items.Count == 0)
            //    viewModel.LoadItemsCommand.Execute(null);
        }
    }
}