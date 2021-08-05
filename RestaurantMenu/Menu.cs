using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
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

        public void AddItem(string name, MenuItems item)
        {
            bool isThere = false;
            foreach (KeyValuePair<string, MenuItems> entry in theMenu)
            {
                string mealName = entry.Key;
                MenuItems mealObj = entry.Value;

                if (mealObj.Equals(item) || theMenu.ContainsKey(name))
                {
                    isThere = true;
                    goto outOfLoop;
                }
            }

            public void RemoveItem(string name, MenuItems item)
            {
                foreach (KeyValuePair<string, MenuItems> entry in theMenu)
                {
                    string mealName = entry.Key;
                    MenuItems mealObj = entry.Value;

                    if (mealObj.Equals(item) && mealName == name)
                    {
                        theMenu.Remove(mealName);
                        break;
                    }
                }

            }

            public void LastUpdate()
            {
                DateTime date = new DateTime();
                foreach (KeyValuePair<string, MenuItems> entry in theMenu)
                {
                    if (DateTime.Compare(entry.Value.updated, date) > 0)
                    {
                        date = entry.Value.updated;
                    }
                }

                lastUpdated = date;
            }

        }
}