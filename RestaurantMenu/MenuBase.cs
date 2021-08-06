namespace RestaurantMenu
{
    public class MenuBase
    {
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

        public void PrintMenu()
        {
            if (theMenu.Count > 0)
            {
                foreach (KeyValuePair<string, MenuItems> entry in theMenu)
                {
                    Console.WriteLine("{0}\n{1}\n******", entry.Key, entry.Value.ToString());
                }
            }

            else
            {
                Console.WriteLine("No items on the menu");
            }
            LastUpdate();
            Console.WriteLine("Menu Updated " + lastUpdated);
        }
    }
}