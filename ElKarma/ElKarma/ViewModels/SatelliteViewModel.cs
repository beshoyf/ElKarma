﻿using ElKarma.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElKarma.ViewModels
{
    public class SatelliteViewModel
    {
        public SatelliteViewModel()
        {

        }
        public List<Satellite> GetItems()
        {
            var items = new List<Satellite>();
            var mockItems = new List<Satellite>
            {
                new Satellite { Image="",Color="#77ce71",Region="North America",SattliteName="Galaxy 19.016W" ,Details="Freq. 1217717 V ,SR 23000,FEC 3/4"},
                new Satellite { Image="",Color="#8d9c9c",Region="Australlia",SattliteName="Galaxy 19.016W" ,Details="Freq. 1217717 V ,SR 23000,FEC 3/4"},
                new Satellite { Image="",Color="#77ce71",Region="Europe",SattliteName="Galaxy 19.016W" ,Details="Freq. 1217717 V ,SR 23000,FEC 3/4"},
                new Satellite { Image="",Color="#8d9c9c",Region="Middel East",SattliteName="Galaxy 19.016W" ,Details="Freq. 1217717 V ,SR 23000,FEC 3/4"}  
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
            return items;
        }
    }
}