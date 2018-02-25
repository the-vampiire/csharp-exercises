using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant {
    class Menu {
    // private 
        private List<MenuItem> items = new List<MenuItem>();
        private string updatedAt = DateTime.Now.ToString();
        private void SetUpdateDate() {
            UpdatedAt = DateTime.Now.ToString();
        }

    // public
        public List<MenuItem> Items {
            get => items;
            set => items = value;
        }

        public string UpdatedAt {
            get => updatedAt;
            set => updatedAt = value;

        }

        public void AddItem(MenuItem menuItem) {
            foreach (MenuItem item in Items) item.NewItem = false;
            Items.Add(menuItem);
            this.SetUpdateDate();
        }

        public void RemoveItem(string name) {
            Items.RemoveAll(e => e.Name == name);
            this.SetUpdateDate();
        }

        public bool HasItem(MenuItem item) { 
            return Items.Contains(item);
        }

        public string ItemString(MenuItem item) {
            return string.Format(
                        "{0}{1}:${2}\n{3}\n\n",
                        item.NewItem ? "New! " : "",
                        item.Name,
                        item.Price,
                        item.Description
            );
        }

        public MenuItem FindItem(string ItemName) => Items.Find(item => item.Name == ItemName);

        public void PrintItem(string ItemName) {
            try {
                MenuItem FoundItem = FindItem(ItemName);
                Console.WriteLine(ItemString(FoundItem));
            }
            catch (NullReferenceException) {
                try {
                    MenuItem FoundItem = FindItem(ItemName.ToLower());
                    Console.WriteLine(ItemString(FoundItem));  
                } catch (NullReferenceException) {
                    Console.WriteLine("No item found");
                }
            } 
        }

        public void PrintItems() {
            Console.WriteLine(string.Format("Last Updated: {0}", this.UpdatedAt));
            foreach (MenuItem item in this.Items) {
                Console.WriteLine(ItemString(item));
            }
        }

    // constructors
        public Menu() {
            
        }

        public Menu(MenuItem item) {
            AddItem(item);
        }

        public Menu(params object[] items) {
            foreach (MenuItem item in items) AddItem(item);
        }

        public Menu(List<MenuItem> items) => Items = items;

    }
}
