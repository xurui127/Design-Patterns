using Abstruct_Factory_Pattern.Pizzas.Abstruction;
using Abstruct_Factory_Pattern.PizzaStores;
using Abstruct_Factory_Pattern.PizzaStores.Abstruction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYPizzaStore();
            Pizza pizza = nyPizzaStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza);
        }
    }
}
