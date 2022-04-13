using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
   public class Waitress
    {
        private MenuComponent menus;


        public Waitress(MenuComponent _menus )
        {
            this.menus = _menus;
        }
        public void PrintMenu()
        {
            menus.Print();
        }
    public void PrintVegetarianMenu()
        {
            var iterator = menus.CreateIterator();
            Console.WriteLine("\n Vegetarian Menu\n---");
            while (iterator.MoveNext())
            {
                MenuComponent menuComponent = iterator.Current;
                try
                {
                    if (menuComponent.isVegetarian)
                    {
                        menuComponent.Print();
                    }
                }
                catch (NotImplementedException)
                {

                  
                }
            }
        }
       
    }
}
