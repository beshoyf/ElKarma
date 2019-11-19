using ElKarma.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElKarma.ViewModels
{
    public  class LiveViewModel
    {
        private List<Live> mockItems;

        public LiveViewModel()
        {

        }
        public List<Live> GetItems(string lang)
        {
          var  items = new List<Live>();
            if (lang == "e")
            {
                mockItems = new List<Live>
                {
                    new Live { Id = Guid.NewGuid().ToString(), Text = "Alkarma NA1", Description="El Karma Tv",Image="Logo_NA1.png" ,WatchUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmana1.smil?type=m3u8"   ,ListenUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmana1-audio?type=m3u8"},
                    new Live { Id = Guid.NewGuid().ToString(), Text = "Alkarma NA2", Description="El Karma Tv",Image="Logo_NA2.png", WatchUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmana2.smil?type=m3u8"   ,ListenUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmana2-audio?type=m3u8"},
                    new Live { Id = Guid.NewGuid().ToString(), Text = "Alkarma Me1", Description="El Karma Tv" ,Image="Logo_ME.png",WatchUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmame1.smil?type=m3u8"   ,ListenUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmame1-audio?type=m3u8"},
                    new Live { Id = Guid.NewGuid().ToString(), Text = "Alkarma Me2", Description="El Karma Tv",Image="Logo_ME2.png",WatchUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmame2.smil?type=m3u8" ,ListenUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmame2-audio?type=m3u8"},
                    new Live { Id = Guid.NewGuid().ToString(), Text = "Alkarma Australia", Description="El Karma Tv",Image="LogoAU.png",WatchUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmaau.smil?type=m3u8" ,ListenUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmaau-audio?type=m3u8"},
                    new Live { Id = Guid.NewGuid().ToString(), Text = "Alkarma US Local", Description="El Karma Tv" ,Image="Logo_US.png",WatchUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmaus.smil?type=m3u8",ListenUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmaus-audio?type=m3u8"},
                    new Live { Id = Guid.NewGuid().ToString(), Text = "Alkarma Praise", Description="El Karma Tv" ,Image="Logo_Praise.png",WatchUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmapa.smil?type=m3u8",ListenUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmapa-audio?type=m3u8"}
                };
            }
            else
            {
                mockItems = new List<Live>
                {
                    new Live { Id = Guid.NewGuid().ToString(), Text = "امريكا& كندا 1", Description="El Karma Tv",Image="Logo_NA1.png" ,WatchUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmana1.smil?type=m3u8"   ,ListenUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmana1-audio?type=m3u8"},
                    new Live { Id = Guid.NewGuid().ToString(), Text = "امريكا& كندا 2", Description="El Karma Tv",Image="Logo_NA2.png", WatchUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmana2.smil?type=m3u8"   ,ListenUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmana2-audio?type=m3u8"},
                    new Live { Id = Guid.NewGuid().ToString(), Text = "الشرق الاوسط", Description="El Karma Tv" ,Image="Logo_ME.png",WatchUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmame1.smil?type=m3u8"   ,ListenUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmame1-audio?type=m3u8"},
                    new Live { Id = Guid.NewGuid().ToString(), Text = "الشرق الاوسط", Description="El Karma Tv",Image="Logo_ME2.png",WatchUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmame2.smil?type=m3u8" ,ListenUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmame2-audio?type=m3u8"},
                    new Live { Id = Guid.NewGuid().ToString(), Text = "استرليا", Description="El Karma Tv",Image="LogoAU.png",WatchUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmaau.smil?type=m3u8" ,ListenUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmaau-audio?type=m3u8"},
                    new Live { Id = Guid.NewGuid().ToString(), Text = "امريكا", Description="El Karma Tv" ,Image="Logo_US.png",WatchUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmaus.smil?type=m3u8",ListenUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmaus-audio?type=m3u8"},
                    new Live { Id = Guid.NewGuid().ToString(), Text = "باريس", Description="El Karma Tv" ,Image="Logo_Praise.png",WatchUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmapa.smil?type=m3u8",ListenUrl="https://5d12bc59c4748.streamlock.net/redirect/alkarmatv.com/alkarmapa-audio?type=m3u8"}
                };
            }

      

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
            return items;
        }
    }
}
