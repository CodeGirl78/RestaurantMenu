using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace RestaurantMenu
{
    public class MenuItems
    {
        public double Price { get; internal set; }
        public string Category { get; internal set; }
        public string Description { get; internal set; }
        public bool IsNew { get; internal set; }
        public DateTime LastUpdated { get; internal set; }

        public MenuItems(double price, string category, string description, bool isNew, DateTime LastUpdated)
        {
            Price = price;
            Category = category;
            Description = description;
            IsNew = isNew;
            this.LastUpdated = LastUpdated;
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

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            MenuItems ToCompare = obj as MenuItems;
            return ToCompare.Description == this.Description;
        }

        public override string ToString()
        {
            return IsItNew() + "\n" + Category + "\nDescription: " + Description + "\nPrice: " + Price + "$";
        }
    }
}