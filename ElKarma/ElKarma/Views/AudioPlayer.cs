using ElKarma.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ElKarma.Views
{
	public class AudioPlayer : ContentPage
	{
		public AudioPlayer ()
		{
            var play = new Button()
            {
                Text = "Play/Pause",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Command = new Command(() =>
                {
                    DependencyService.Get<IAudio>().Play_Pause("https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmana1-audio?type=m3u8");
                })
            };
            var stop = new Button()
            {
                Text = " Stop ",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Command = new Command(() =>
                {
                    DependencyService.Get<IAudio>().Stop(true);
                })
            };

            StackLayout holder = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = { play, stop }
            };
            Content = new StackLayout()
            {
                Children = { holder }
            };
        }
	}
}