using System;

namespace RestaurantMenu
{
    public class Restaurant
    {
        static void Main(string[] args)
        {
            MenuItems item1 = new MenuItems(9.99, "Main", "Savory Smoked Brisket, House Spread, Green Chili Coleslaw, Barbecue Sauce, and Freshly Grated Cheddar Cheese on freshly baked sourdough.", false, new DateTime(2019, 1, 2));
            MenuItems item2 = new MenuItems(8.99, "Main", "Roast Beef Thinly Sliced, House Spread, Freshly Grated Swiss Cheese, and Au Jus piled on top of freshly baked sourdough.", true, new DateTime(2018, 1, 2));

            Menu myMenu = new Menu();
            myMenu.AddItem("Smoked Brisket Sub", item1);
            myMenu.AddItem("French Dip Sub", item2);

            Console.WriteLine(item1.ToString());
            Console.WriteLine(">>>><<<<");

            myMenu.PrintMenu();
            Console.WriteLine(">>>><<<<");


            myMenu.RemoveItem("Smoked Brisket Sub", item1);
            myMenu.PrintMenu();
            Console.WriteLine(">>>><<<<");

            myMenu.AddItem("French Dip Sub", item2);

        }
    }
}