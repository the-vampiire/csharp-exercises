using System;
using System.Collections.Generic;

namespace Restaurant2
{
    public class Menu
    {
        private List<MenuItem> menuItems;
        public List<MenuItem> MenuItems {
            get => menuItems;
            // arrow functions c#
            // these two are equivilint
            //get {
            //    return menuItems;
            //}
            set => menuItems = value;
        }

        private string updatedAt = DateTime.Now.ToString();
        public string UpdatedAt
        {
            get => updatedAt;
            set => updatedAt = value;
        }

        public override string ToString()
        {
            if (MenuItems.Count == 0) return "other string goes here"; // some other string;

            string outputString = "";
            //foreach(Type elementvariablename in iterablename) {}
            foreach(MenuItem item in MenuItems) {
                outputString += item.ToString();
            }

            // what happens if there are no items in our MenuItems?
                // as it is written we get an empty string
                // can we detect an empty string and return something else?
            return outputString;
        }

        //privacy level return type name (Type params) = 
        public void AddItem(MenuItem item) {
            MenuItems.Add(item);
        }

        public void RemoveItem(string itemName) {
            // check for case and mispelling
            // i need to find an item in a list using its name
            // i need to remove that item from the list
        }

        public void RemoveItem(MenuItem item) {
            // i need to remove the passed item from the list
        }

        public bool HasItem(MenuItem item) {
            // check if item exists in MenuItems List
            // return true or false
            return MenuItems.Contains(item);
        }
        // 
        NewMenu.HasItem(Pizza1);
        NewMenu.HasItem(Pizza2);
       
        public Menu()
        {
        }
    }
}

/* Menu
 *
 * Properties
 * list of menu items MenuItems
 * categories[on Menu and on MenuItems]
 * updated at time
 *
 * Methods
 * a way to print menu items
 * override using keyword override ToString method
 * write a separate method
* add and remove items
* check if the menu has an item
* find an item
 * constructors
*/
