using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern.SubClasses
{
   public class PopcornPopper
    {
        private string description;
        public PopcornPopper(string _description)
        {
            description = _description;
        }
        public void On()
        {
            Console.WriteLine($"{description} On");
        }
        public void Off()
        {
            Console.WriteLine($"{description} Off");
        }
        public void Pop()
        {
            Console.WriteLine($"{description} Popping Popcorn");
        }
        public override string ToString()
       {
            return description;
        }
    }
}
