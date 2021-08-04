using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class Menu
    {
        public Dictionary<string, MenuItems> theMenu = new Dictionary<string, MenuItems>();

        public Menu(Dictionary<string, MenuItems> theMenu)
        {
            this.theMenu = theMenu;
        }

        public DateTime lastUpdated = new DateTime();
    }
}