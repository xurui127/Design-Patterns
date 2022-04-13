using System;
using System.Collections.Generic;
using System.Text;

namespace DinerMerge
{
   public class MenuItem
    {
        public string name { get; }
        public string description { get; }
        public bool isVegetarian { get; }
        public double price { get; }

        public MenuItem(string _name,string _description, bool _isVegetarian, double _price)
        {
            name = _name;
            description = _description;
            isVegetarian = _isVegetarian;
            price = _price;
        }
        public override string ToString()
        {
            return $"{name}, ${price.ToString()} \n  {description}";
        }
    }
}
