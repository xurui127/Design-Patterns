using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
   public class Mocha : CondimentDecorator
    {
        public Mocha( Beverage _beverage)
        {
            this.beverage = _beverage;
            
        }
    
        public override string GetDescription()
        {
            
            return beverage.GetDescription() + " , Mocha";
        }

    

        public override double Cost()
        {
            return beverage.Cost() + 0.20f;
        }

   
    }
}
