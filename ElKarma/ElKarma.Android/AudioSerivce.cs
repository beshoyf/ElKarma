using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
 
using Xamarin.Forms;
using ElKarma.Droid;
using Android.Media;
using ElKarma.Shared;

[assembly: Dependency(typeof(AudioSerivce))]
namespace ElKarma.Droid
{
    class AudioSerivce : IAudio
    {
        int clicks = 0;
        MediaPlayer player;
        public AudioSerivce()
        {
        }

        public bool Play_Pause(string url)
        {
            if (clicks == 0)
            {
                this.player = new MediaPlayer();
                player.SetDataSource(url);
                player.SetAudioStreamType(Stream.Music);
                this.player.PrepareAsync();
                this.player.Start();
                clicks++;
            }
            else if (clicks % 2 != 0)
            {
                this.player.Pause();
                clicks++;

            }
            else
            {
                this.player.Start();
                clicks++;
            }


            return true;
        }

        public bool Stop(bool val)
        {
            this.player.Stop();
            clicks = 0;
            return true;
        }
    }
}