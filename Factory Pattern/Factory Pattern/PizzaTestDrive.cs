using Factory_Pattern.Pizzas.Abstruction;
using Factory_Pattern.PizzaStores;
using Factory_Pattern.PizzaStores.Abstruction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    class PizzTestDrive
    {
        static void Main(string[] args)
        {

            //PizzaStore nyStore = new NYStylePizzaStore();
            //PizzaStore chicagoStore = new ChicagoStylePizzaStore();

            //Pizza pizza = nyStore.OrderPizza("cheese");
            //Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            //pizza = chicagoStore.OrderPizza("cheese");
            //Console.WriteLine("Joel ordered a " + pizza.GetName() + "\n");

            PizzaStore nyPizzaStore = new NYPizzaStore();
             Pizza pizza =  nyPizzaStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza);
        }
    }
}
