using System;
using System.Collections.Generic;
using System.Text;

namespace Barista
{
    public class Coffee : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar And Milk");
        }

        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee Through Filter");
        }
    }
}
