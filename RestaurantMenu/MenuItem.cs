using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace RestaurantMenu
{
    public class MenuItems
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }
        public DateTime updated { get; set; }

        public MenuItems(string name, double price, string description, string category, bool isNew, DateTime updated)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
            this.updated = updated;
        }

        public string IsItNew()
        {
            if (IsNew)
            {
                return "NEW!!";
            }
            else
            {
                return "Classic Meal";
            }
        }


    }
}