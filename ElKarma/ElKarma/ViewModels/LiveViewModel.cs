using ElKarma.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElKarma.ViewModels
{
    public  class LiveViewModel
    {
        public LiveViewModel()
        {

        }
        public List<Live> GetItems()
        {
          var  items = new List<Live>();
            var mockItems = new List<Live>
            {
                new Live { Id = Guid.NewGuid().ToString(), Text = "Alkarma NA1", Description="El Karma Tv",Image="" ,WatchUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmana1.smil?type=m3u8"   ,ListenUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmana1-audio?type=m3u8"},
                new Live { Id = Guid.NewGuid().ToString(), Text = "Alkarma NA2", Description="El Karma Tv",Image="", WatchUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmana2.smil?type=m3u8"   ,ListenUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmana2-audio?type=m3u8"},
                new Live { Id = Guid.NewGuid().ToString(), Text = "Alkarma Me1", Description="El Karma Tv" ,Image="",WatchUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmame1.smil?type=m3u8"   ,ListenUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmame1-audio?type=m3u8"},
                new Live { Id = Guid.NewGuid().ToString(), Text = "Alkarma Me2", Description="El Karma Tv",Image="",WatchUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmame2.smil?type=m3u8" ,ListenUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmame2-audio?type=m3u8"},
                new Live { Id = Guid.NewGuid().ToString(), Text = "Alkarma Australia", Description="El Karma Tv",Image="",WatchUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmaau.smil?type=m3u8" ,ListenUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmaau-audio?type=m3u8"},
                new Live { Id = Guid.NewGuid().ToString(), Text = "Alkarma US Local", Description="El Karma Tv" ,Image="",WatchUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmaus.smil?type=m3u8",ListenUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmaus-audio?type=m3u8"},
                new Live { Id = Guid.NewGuid().ToString(), Text = "Alkarma Praise", Description="El Karma Tv" ,Image="",WatchUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmapa.smil?type=m3u8",ListenUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmapa-audio?type=m3u8"}
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
            return items;
        }
    }
}
