using System;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating (creating) instances of the MenuItem class
            MenuItem Pizza1 = new MenuItem(
               "California Pizza Kitchen BBQ Chicken",
               "I was hungry when I wrote this",
               "main course",
               16.96
           );

            MenuItem Pizza2 = new MenuItem(
               "California Pizza Kitchen BBQ Chicken",
               "I was hungry when I wrote this",
               "main course",
               16.96
           );

            MenuItem CulversChickenFingers = new MenuItem(
                "Culver's Chicken Fingers",
                "Damn near illegal levels of deliciousness",
                "appetizer",
                5.96
            );

            Menu NewMenu = new Menu(Pizza1, CulversChickenFingers);


            while (true)
            {
                Console.WriteLine("Enter 'q' to quit or hit any other button to continue");
                string Response = Console.ReadLine();
                if (Response.Equals("q")) break;
                Console.WriteLine("Enter 0 to view the entire menu\nEnter 1 to search for an item");
                string ChoiceResponse = Console.ReadLine();

                if (ChoiceResponse == "0") NewMenu.PrintItems();


                // add an ID property to search by
                // implement an ID refresh method
                else if (ChoiceResponse == "1")
                {
                    foreach (MenuItem item in NewMenu.Items)
                    {
                        Console.WriteLine(string.Format("{0}", item.Name));
                    }
                    Console.WriteLine("Enter a menu item to search for");
                    string ItemName = Console.ReadLine();
                    NewMenu.PrintItem(ItemName);
                }

                else Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }
}

/**
 * 
 * Menu
 * 
 * Properties
 * list of menu items MenuItems
 * categories [on Menu and on MenuItems]
 * updated at time 
 * 
 * Methods
 * a way to print menu items
 *   override using keyword override ToString method
 *   write a separate method
 * add and remove items
 * check if the menu has an item
 * find an item
 * constructors
 * 
 * Menu Items
 * 
 * Properties
 * name, description, price, newitem, category
 * a way to print a menu item
 *   override the ToString method
 * 
 * Methods
 * constructor
 * 
 */
