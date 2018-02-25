using System;
using System.Linq;

namespace Restaurant {
    public class MenuItem {
        // private
        private int id;
        private string name;
        private string description;
        private double price;
        private string category;
        private bool newItem = true;

        private string[] categories = new string[]
        { "appetizer", "main course", "dessert" };

    // public
        public int Id {
            get => id;
            set => id = value;
        }

        public string Name {
            get => name;
            set => name = value;
        }

        public string Description {
            get => description;
            //set => description = value;

            set {
                // we want to update the New Item boolean when description is updated
                NewItem = true;
                description = value;
            }
        }

        /*

        menuitem = instance of a MenuItem class

        menuitem.Description = "some new description that we are updating"
            it will first go through the setter method [set] of the Description property
            when it enters the setter method it will update the NewItem property and set it to true
            
        */

        public double Price {
            get => price;
            set => price = value;
        }

        // if we had exposed a plain field we lose the validation of getters and setters
        //public string Category;
        // menuItemInstance.Category = any value you want with no validation
        public string Category {
            get => category;
            set {
                /**
                 * 
                 * the case where value IS in the categories array
                     * categories.Contains(value) ->
                     * return true -> flipped by ! negating operator -> if (false)
                     * false so it skips the throw error block and enters the else
                     * where the value is assigned
                 * 
                 * the case where value IS NOT in the categories array
                     * categories.Contains(value) ->
                     * return false -> flipped by ! negating operator -> if (true)
                     * true so it enter the throw error block and throws an error
                 * 
                 **/
                if (!categories.Contains(value))
                    throw new Exception("Invalid category");
                else category = value;
            }
        }

        public bool NewItem {
            get => newItem;
            set => newItem = value;
        }

    // constructor
        public MenuItem(
            string inputName,
            string description,
            string category,
            double price
        ) {
            name = inputName; // this is assigning a value DIRECTLY to a field
            Name = name;
            Description = description;
            Category = category;
            Price = price;
        }
    }
}
