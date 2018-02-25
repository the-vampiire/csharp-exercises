using System;
using System.Linq;

namespace Restaurant {
    public class MenuItem {
    // private
        private string name;
        private string description;
        private double price;
        private string category;
        private bool newItem = true;

        private string[] categories = new string[]
        { "appetizer", "main course", "dessert" };

    // public
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
