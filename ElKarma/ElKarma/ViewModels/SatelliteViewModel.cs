using ElKarma.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElKarma.ViewModels
{
    public class SatelliteViewModel
    {
        private IEnumerable<Satellite> mockItems;

        public SatelliteViewModel()
        {

        }
        public List<Satellite> GetItems(string lang)
        {
            var items = new List<Satellite>();
            
            if (lang == "e")
            {
                 mockItems = new List<Satellite>
                {
                    new Satellite { Image="",Color="#77ce71",Region="N. America & Canada & Mexico",SattliteName="Alkarma NA1 (G19) (97.0° west)" ,Details="Freq: 12,177 Vertical - SR 23,000 - 3/4"},
                    new Satellite { Image="",Color="#910319",Region="N. America & Canada & Mexico",SattliteName="Alkarma NA2 (G19) (97.0° west)" ,Details="Freq: 11,867 Vertical - SR 22,000 - 3/4"},
                    new Satellite { Image="",Color="#8d9c9c",Region="Parts of Europe, All Middle East",SattliteName="Alkarma ME1 (Nile Sat) (E8WB) Eutelsat 8°W)" ,Details="Freq: 11,096 Horizontal - SR 27,500 - 5/6"},
                    new Satellite { Image="",Color="#77ce71",Region="All Europe",SattliteName="Alkarma ME1 (HotBird 6) at 13.0°E" ,Details="Freq: 11,179 Horizontal - SR 27,500 - 3/4"},
                    new Satellite { Image="",Color="#910319",Region="Parts of Europe, All Middle East",SattliteName="Alkarma ME1 (Arab Sat) EB2 – (25.5° East)" ,Details="Freq: 11,678 Horizontal - SR 27,500 - 5/6"},
                    new Satellite { Image="",Color="#8d9c9c",Region="Turky",SattliteName="Alkarma (Turky) ME1 (Turk Sat) (42° East)" ,Details="Freq. 11,824 Vertical - SR 8.000 - 3/4"},
                    new Satellite { Image="",Color="#77ce71",Region="ARE",SattliteName="Alkarma Yasat" ,Details="Freq: 10.720,5 Horizontal -  SR: 27.500    5/6"},
                    new Satellite { Image="",Color="#910319",Region="Indonesia and Malaysia",SattliteName="Alkarma ME2 (Palapa) (113.0° East)" ,Details="Freq: 4,140 Vertical - SR 30,000 - 7/8"},
                    new Satellite { Image="",Color="#8d9c9c",Region="Africa",SattliteName="Alkarma  ME2 (IS 10) (47.5° East)" ,Details="Freq: 12,602 Vertical - SR 27,500 - 3/4"},
                    new Satellite { Image="",Color="#77ce71",Region="South America",SattliteName="Alkarma  ME2 (Hispast) (30.0° west)" ,Details="Freq: 12,095 Vertical - SR 27,000 - 3/4"},
                    new Satellite { Image="",Color="#910319",Region="Asia",SattliteName="Alkarma (AS 5) ME2 ASIA SAT 5 (100.5° East)" ,Details="Freq: 3.960 Horizontal - SR 30.000 - 7/8"},
                    new Satellite { Image="",Color="#8d9c9c",Region="Australia & New Zeeland",SattliteName="Alkarma AU (Optus D2)" ,Details="Freq: 12,546 Vertical - SR: 22.500 - 3/4"},
                    new Satellite { Image="",Color="#77ce71",Region="Parts of Europe, All Middle East",SattliteName="ALKARMA Praise (Nile Sat) (E8WB) Eutelsat 8°W" ,Details="Freq: 11,354 Vertical - SR 27.500 - 3/4"}
                };
            }
            else
            {
                 mockItems = new List<Satellite>
                {
                    new Satellite { Image="",Color="#77ce71",Region="جنوب امريكا & كندا & المكسيك",SattliteName="Alkarma NA1 (G19) (97.0° west)" ,Details="Freq: 12,177 Vertical - SR 23,000 - 3/4"},
                    new Satellite { Image="",Color="#910319",Region="جنوب امريكا & كندا & المكسيك",SattliteName="Alkarma NA2 (G19) (97.0° west)" ,Details="Freq: 11,867 Vertical - SR 22,000 - 3/4"},
                    new Satellite { Image="",Color="#8d9c9c",Region="الوطن العربى",SattliteName="Alkarma ME1 (Nile Sat) (E8WB) Eutelsat 8°W)" ,Details="Freq: 11,096 Horizontal - SR 27,500 - 5/6"},
                    new Satellite { Image="",Color="#77ce71",Region="اوربا",SattliteName="Alkarma ME1 (HotBird 6) at 13.0°E" ,Details="Freq: 11,179 Horizontal - SR 27,500 - 3/4"},
                    new Satellite { Image="",Color="#910319",Region="جزء من اوربا & الوطن العربى",SattliteName="Alkarma ME1 (Arab Sat) EB2 – (25.5° East)" ,Details="Freq: 11,678 Horizontal - SR 27,500 - 5/6"},
                    new Satellite { Image="",Color="#8d9c9c",Region="تركيا",SattliteName="Alkarma (Turky) ME1 (Turk Sat) (42° East)" ,Details="Freq. 11,824 Vertical - SR 8.000 - 3/4"},
                    new Satellite { Image="",Color="#77ce71",Region="الامارات",SattliteName="Alkarma Yasat" ,Details="Freq: 10.720,5 Horizontal -  SR: 27.500    5/6"},
                    new Satellite { Image="",Color="#910319",Region="اندونسيا & ماليزيا",SattliteName="Alkarma ME2 (Palapa) (113.0° East)" ,Details="Freq: 4,140 Vertical - SR 30,000 - 7/8"},
                    new Satellite { Image="",Color="#8d9c9c",Region="افريقيا",SattliteName="Alkarma (Africa) ME2 (IS 10) (47.5° East)" ,Details="Freq: 12,602 Vertical - SR 27,500 - 3/4"},
                    new Satellite { Image="",Color="#77ce71",Region="جنوب امريكا",SattliteName="Alkarma  ME2 (Hispast) (30.0° west)" ,Details="Freq: 12,095 Vertical - SR 27,000 - 3/4"},
                    new Satellite { Image="",Color="#910319",Region="أسيا",SattliteName="Alkarma (AS 5) ME2 ASIA SAT 5 (100.5° East)" ,Details="Freq: 3.960 Horizontal - SR 30.000 - 7/8"},
                    new Satellite { Image="",Color="#8d9c9c",Region="استرليا & نيوزلاندا",SattliteName="Alkarma AU (Optus D2)" ,Details="Freq: 12,546 Vertical - SR: 22.500 - 3/4"},
                    new Satellite { Image="",Color="#77ce71",Region="جزء من اوربا & الوطن العربى",SattliteName="ALKARMA Praise (Nile Sat) (E8WB) Eutelsat 8°W" ,Details="Freq: 11,354 Vertical - SR 27.500 - 3/4"}
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
