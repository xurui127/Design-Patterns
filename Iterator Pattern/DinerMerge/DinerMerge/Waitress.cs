using System;
using System.Collections.Generic;
using System.Text;

namespace DinerMerge
{
   public class Waitress
    {
        private IMenu pancakeHouseMenu;
        private IMenu dinerMenu;

        public Waitress (IMenu _pancakeHouseMenu, IMenu _dinerMenu)
        {
            pancakeHouseMenu = _pancakeHouseMenu;
            dinerMenu = _dinerMenu;
        }
        public void PrintMenu()
        {
            IIterator pancakeIterator = pancakeHouseMenu.CreateIterator();
            IIterator dinerIterator = dinerMenu.CreateIterator();

            Console.WriteLine("MENU");
            Console.WriteLine("------");
            Console.WriteLine("Breakfast");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLunch");
            PrintMenu(dinerIterator);
        }
        private void PrintMenu(IIterator _iterator)
        {
            while (_iterator.HasNext())
            {
                MenuItem menuItem = _iterator.Next();
                Console.WriteLine($"{menuItem.name}, {menuItem.price.ToString()}");
                Console.WriteLine(menuItem.description);
              
            }
        }
        public void PrintVegetarianMenu() 
        {
            PrintVegetarianMenu(pancakeHouseMenu.CreateIterator());
            PrintVegetarianMenu(dinerMenu.CreateIterator());
        }

        private void PrintVegetarianMenu(IIterator _iterator)
        {
            while (_iterator.HasNext())
            {
                MenuItem menuItem = _iterator.Next();
                if (menuItem.isVegetarian)
                {
                    Console.WriteLine($"{menuItem.name} \t\t {menuItem.price.ToString()}"); ;
                    Console.WriteLine("\t" + menuItem.description);
                }
            }
        }
        private bool IsVegetarian(string _name,IIterator _iterator)
         {
            while (_iterator.HasNext())
            {
                MenuItem menuItem = _iterator.Next();
                if (menuItem.name == _name && menuItem.isVegetarian)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
