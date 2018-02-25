using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant {
    class Program {
        static void Main(string[] args) {
            MenuItem Pizza = new MenuItem(
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
            Menu NewMenu = new Menu(Pizza, CulversChickenFingers);
            NewMenu.PrintItems();
            Console.ReadLine();
        }
    }
}
