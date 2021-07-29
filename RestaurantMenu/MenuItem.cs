using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public bool IsNew { get; set; }


        public MenuItem(string name, string description, string category, double price, bool isNew)
        {
            Name = name;
            Description = description;
            Category = category;
            Price = price;
            IsNew = isNew;
        }
    }
}