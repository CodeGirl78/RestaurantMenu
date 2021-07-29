using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class Menu
    {
        public string MenuItem { get; set; }
        public DateTime LastUpdated { get; set; }


        public Menu(string menuItem, DateTime lastUpdated)
        {
            MenuItem = menuItem;
            LastUpdated = lastUpdated;
            //LastUpdated =  DateTime.Now ??
        }
    }
}
