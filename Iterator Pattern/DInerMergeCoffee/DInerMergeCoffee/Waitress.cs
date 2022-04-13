using System;
using System.Collections.Generic;
using System.Text;

namespace DinerMergeCoffee
{
  public  class Waitress
    {
        private IMenu pancakeHouseMenu;
        private IMenu dinerMenu;
        private IMenu cafeMenu;

        public Waitress(IMenu _pancakeHouseMenu, IMenu _dinerMenu,IMenu _cafeMenu)
        {
            pancakeHouseMenu = _pancakeHouseMenu;
            dinerMenu = _dinerMenu;
            cafeMenu = _cafeMenu;
        }
        public void PrintMenu()
        {
            var pancakeIterator = pancakeHouseMenu.CreateIterator();
            var dinerIterator = dinerMenu.CreateIterator();
            var cafeIterator = cafeMenu.CreateIterator();
            Console.WriteLine("MENU");
            Console.WriteLine("------");
            Console.WriteLine("Breakfast");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLunch");
            PrintMenu(dinerIterator);
            Console.WriteLine("\nDiner");
            PrintMenu(cafeIterator);
        }
        private void PrintMenu(IEnumerator<MenuItem> _iterator)
        {
            while (_iterator.MoveNext())
            {
                MenuItem menuItem = _iterator.Current;
                Console.WriteLine($"{menuItem.name}, {menuItem.price.ToString()}");
                Console.WriteLine(menuItem.description);

            }
        }
        public void PrintVegetarianMenu()
        {
            Console.WriteLine("\n VEGETARIAN MENU\n -----");
            PrintVegetarianMenu(pancakeHouseMenu.CreateIterator());
            PrintVegetarianMenu(dinerMenu.CreateIterator());
            PrintVegetarianMenu(cafeMenu.CreateIterator());
        }

        private void PrintVegetarianMenu(IEnumerator<MenuItem> _iterator)
        {
            while (_iterator.MoveNext())
            {
                MenuItem menuItem = _iterator.Current;
                if (menuItem.isVegetarian)
                {
                    Console.WriteLine($"{menuItem.name} \t\t {menuItem.price.ToString()}"); ;
                    Console.WriteLine("\t" + menuItem.description);
                }
            }
        }
        private bool IsVegetarian(string _name, IEnumerator<MenuItem> _iterator)
        {
            IEnumerator<MenuItem> _pancakeIterator = pancakeHouseMenu.CreateIterator();
              
                if (IsVegetarian(_name,_pancakeIterator))
                {
                    return true;
                }
            IEnumerator<MenuItem> _dinerIterator = dinerMenu.CreateIterator();

            if (IsVegetarian(_name, _dinerIterator))
            {
                return true;
            }
            IEnumerator<MenuItem> _cafeIterator = cafeMenu.CreateIterator();

            if (IsVegetarian(_name, _cafeIterator))
            {
                return true;
            }


            return false;
        }

    }
}

