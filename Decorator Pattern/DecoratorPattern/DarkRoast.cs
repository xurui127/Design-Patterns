using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }
        public override double Cost()
        {
            return 0.77f;
        }



    }
}
