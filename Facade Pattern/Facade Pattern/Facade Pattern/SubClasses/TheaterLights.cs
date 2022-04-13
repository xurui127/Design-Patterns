using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern.SubClasses
{
   public class TheaterLights
    {
        private string description;
        public TheaterLights(string _description)
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
        public void Dim(int _lvl)
        {
            Console.WriteLine($"{description} Dim To {_lvl.ToString()}");
        }
        public override string ToString()
        {
            return description;
        }
    }
}
