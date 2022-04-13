using System;
using System.Collections.Generic;
using System.Text;

namespace DinerMergeCoffee
{
    public class CafeMenu : IMenu
    {
        private Dictionary<string, MenuItem> menuItems = new Dictionary<string, MenuItem>();

        public CafeMenu()
        {
            AddItem("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99);
            AddItem("Soup of day", "A cup of the soup of the day, with a side salad", false, 3.69);
            AddItem("Burrito", "A large burrito, with whole pinto beans, salad, guacamole", true, 4.29);
        }
        public void AddItem(string _name,string _description,bool _vegetarian,double _price)
        {
            var menuItem = new MenuItem(_name, _description, _vegetarian, _price);
            menuItems.Add(menuItem.name, menuItem);
        }
        public Dictionary<string, MenuItem> GetItems()
        {
            return menuItems;
        }
        public IEnumerator<MenuItem> CreateIterator()
        {
            return menuItems.Values.GetEnumerator();
        }
    }
}
