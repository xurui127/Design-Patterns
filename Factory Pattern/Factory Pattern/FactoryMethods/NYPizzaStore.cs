using Factory_Pattern.FactoryMethods.Abstruction;
using Factory_Pattern.Pizzas.Abstruction;
using System;
using System.Collections.Generic;
using System.Text;


namespace Factory_Pattern.PizzaStores
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case "cheese":
                   
                        break;
                case "veggie":
                    break;
                case "clam":
                    break;
                case "pepperoni":
                    break;
            }
            return pizza;
        }
    }
}
