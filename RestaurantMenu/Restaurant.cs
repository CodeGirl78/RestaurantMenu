using System;

namespace RestaurantMenu
{
    public class Restaurant
    {
        static void Main(string[] args)
        {
            MenuItems item1 = new MenuItems(9.99, "Main", "Savory smoked brisket, house spread, green chili coleslaw, barbecue sauce, and freshly grated cheddar cheese on freshly baked sourdough.", false, new DateTime(2020, 1, 2));
            MenuItems item2 = new MenuItems(8.99, "Main", "Thinly sliced roast beef, house spread, freshly grated Swiss cheese, and au jus piled on top of freshly baked sourdough.", true, new DateTime(2019, 1, 2));

            Menu myMenu = new Menu();
            myMenu.AddItem("Smoked Brisket Sub", item1);
            myMenu.AddItem("Roast Beef Sub", item2);

            Console.WriteLine(item1.ToString());
            Console.WriteLine(">>>><<<<");

            myMenu.PrintMenu();
            Console.WriteLine(">>>><<<<");


            myMenu.RemoveItem("Smoked Brisket Sub", item1);
            myMenu.PrintMenu();
            Console.WriteLine(">>>><<<<");

            myMenu.AddItem("Roast Beef Sub", item2);
        }
    }
}