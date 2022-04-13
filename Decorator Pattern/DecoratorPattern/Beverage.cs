using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
   public abstract class Beverage
    {
        protected  string description = " Unknow";
         public virtual string GetDescription()
        {
            return description;
        }
        public abstract double Cost();
    }
}
