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
            set => description = value;
        }

        public double Price {
            get => price;
            set => price = value;
        }

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
            string name,
            string description,
            string category,
            double price
        ) {
            Name = name;
            Description = description;
            Category = category;
            Price = price;
        }
    }
}
