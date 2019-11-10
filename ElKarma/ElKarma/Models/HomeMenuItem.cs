using System;
using System.Collections.Generic;
using System.Text;

namespace ElKarma.Models
{
    public enum MenuItemType
    {
        Home,
        Satalite,
        Contact,
        About,
        Setting
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
        public string Icon { get; internal set; }
        public bool HasSprator { get; internal set; }
    }
}
