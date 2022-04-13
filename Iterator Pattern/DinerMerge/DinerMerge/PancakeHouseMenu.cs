using System;
using System.Collections.Generic;
using System.Text;

namespace DinerMerge
{
   public class PancakeHouseMenu:IMenu
    {
        private List<MenuItem> menuItems;
        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();
            AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, and sausage", false, 2.99);
            AddItem("Blueberry Pancakes", "Pancakes with fresh blueberries", true, 3.49);
            AddItem("Waffles", "Waffles with you choice of blueberries or strawberries", true, 3.59);

            
        }
        public void AddItem(string _name, string _description, bool _vegetarian, double price)
        {
            var menuItem = new MenuItem(_name, _description, _vegetarian, price);
            menuItems.Add(menuItem);
        }

        public IIterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(menuItems);
        }

        public List<MenuItem> GetMenuItems()
        {
            return menuItems;
        }
    }
}
