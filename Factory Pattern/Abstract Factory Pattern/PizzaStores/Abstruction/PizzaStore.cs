
using Abstruct_Factory_Pattern.Pizzas.Abstruction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstruct_Factory_Pattern.PizzaStores.Abstruction
{
   public abstract class  PizzaStore
    {
        public abstract Pizza CreatePizza(string type);
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);

            Console.WriteLine("--- Making a " + pizza.Name + " ---"); ;

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

      
    }
}
