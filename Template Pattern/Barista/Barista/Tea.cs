using System;
using System.Collections.Generic;
using System.Text;

namespace Barista
{
    public class Tea : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Steeping The Tea");
        }

    }
}
