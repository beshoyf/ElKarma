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
	public partial class LivePlayer : ContentPage
	{
		public LivePlayer(string WatchUrl,string channel)
		{
			InitializeComponent();
            SatBar.Text = channel;
             
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<!DOCTYPE html>
                                <html>
                                <head>
                                </head>
                                <body>
                                <iframe width='100%' height='300' src='"+WatchUrl+"' frameborder='0' allow='autoplay; fullscreen' allowfullscreen></iframe> </ body > ";
            Player.Source = htmlSource;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}