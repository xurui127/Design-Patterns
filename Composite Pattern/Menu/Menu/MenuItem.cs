using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    public class MenuItem : MenuComponent
    {
        public override string name { get; }
        public override string description { get; }
        public override double price { get; }
        public override bool isVegetarian { get; }

        public MenuItem(string _name,string _description,bool _vegetaian,double _price)
        {
            name = _name;
            description = _description;
            isVegetarian = _vegetaian;
            price = _price;
        }
        public override IEnumerator<MenuComponent> CreateIterator()
        {
            return new NullIterator();
        }

        public override void Print()
        {
            Console.WriteLine(" " + name);
            if (isVegetarian)
            {
                Console.WriteLine("(v)");
            }
            Console.WriteLine(", " + price.ToString());
            Console.WriteLine("  -- " + description);
        }
    }
}
