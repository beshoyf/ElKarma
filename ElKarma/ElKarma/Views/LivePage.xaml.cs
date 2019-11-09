using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ElKarma.Models;
using ElKarma.Views;
using ElKarma.ViewModels;

namespace ElKarma.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LivePage : ContentPage
    {
        LiveViewModel viewModel;
        IEnumerable<Live> lives;
        public LivePage()
        {
            InitializeComponent();

            viewModel = new LiveViewModel();
             
           // BindingContext = viewModel.GetItems();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Live;
            if (item == null)
                return;

           // await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ItemsListView.ItemsSource=lives= viewModel.GetItems();
            Live.Text = "Live";
             
            //if (viewModel.Items.Count == 0)
            //    viewModel.LoadItemsCommand.Execute(null);
        }

        private void Watch_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            string id =btn.ClassId.ToString();
            var live = lives.Where(m => m.Id == id).FirstOrDefault();
            Navigation.PushAsync(new LivePlayer(live.WatchUrl,live.Text));
        }

        private void Listen_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            string id = btn.ClassId.ToString();
            var live = lives.Where(m => m.Id == id).FirstOrDefault();
            Navigation.PushAsync(new LivePlayer(live.ListenUrl, live.Text));
        }
    }
}