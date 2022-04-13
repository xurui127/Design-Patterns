using System;
using System.Collections.Generic;
using System.Text;

namespace DinerMergeCoffee
{
   public  class DinerMenu:IMenu
    {
        private const int MAX_ITEMS = 6;
        private int numberOfItems;
        private MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];
            AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT", " Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.99);
            AddItem("HotDog", "A hot dog, with sauerkraut, relish, onions, topped with cheese", false, 3.05);
            AddItem("Steamed Veggies and Brown Rice", "Steamed vegetables over brown rice", true, 3.99);
           AddItem("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread", true, 3.89);
        }
        public void AddItem(string _name, string _description, bool _vegetarian, double _price)
        {
            MenuItem menuItem = new MenuItem(_name, _description, _vegetarian, _price);
            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            }
            else
            {
                menuItems[numberOfItems++] = menuItem;
            }

        }

        public IEnumerator<MenuItem> CreateIterator()
        {
            return new DinerMenuIterator(menuItems);
        }

        public MenuItem[] GetMenuItems()
        {
            return menuItems;
        }


    }
}

