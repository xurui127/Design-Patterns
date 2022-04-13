using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
   public class Menus:MenuComponent
    {
        private List<MenuComponent> menuComponents = new List<MenuComponent>();
        private CompositeIterator iterator;
        public override string name { get; }
        public override string description { get; }

        public Menus(string _name,string _description)
        {
            name = _name;
            description = _description;

        }
        public override void Add(MenuComponent _menuComponent)
        {
            menuComponents.Add(_menuComponent);
        }
        public override void Remove(MenuComponent _menuComponent)
        {
            menuComponents.Remove(_menuComponent);
        }
        public override void Print()
        {
            Console.WriteLine("\n "+ name);
            Console.WriteLine(", " + description);
            Console.WriteLine("---------");

            var iterator = menuComponents.GetEnumerator();
            while (iterator.MoveNext())
            {
                MenuComponent menuComponent = iterator.Current;
                menuComponent?.Print();
            }
        }
        public override IEnumerator<MenuComponent> CreateIterator()
        {
            return iterator ?? (iterator = new CompositeIterator(menuComponents.GetEnumerator()));
        }
    }
}
