using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Soya : CondimentDecorator
    {
        public Soya(Beverage _beverage)
        {
            beverage = _beverage;

        }

        public override double Cost()
        {
            return beverage.Cost() + 0.89f;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " , Soya";
        }
    }
}

