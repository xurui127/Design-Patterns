using Abstruct_Factory_Pattern.AbstructFactory;
using Abstruct_Factory_Pattern.AbstructiFactory;
using Abstruct_Factory_Pattern.Pizzas;
using Abstruct_Factory_Pattern.Pizzas.Abstruction;
using Abstruct_Factory_Pattern.PizzaStores.Abstruction;
using System;
using System.Collections.Generic;
using System.Text;


namespace Abstruct_Factory_Pattern.PizzaStores
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory pizzaIngredient = new NYPizzaIngredientFactory();

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(pizzaIngredient) { Name = "New York Style Cheese Pizza" };
                        break;
                case "veggie":
                    pizza = new VeggiePizza(pizzaIngredient) { Name = "New York Style Veggie Pizza" };
                    break;
                case "clam":
                    pizza = new ClamPizza(pizzaIngredient) { Name = "New York Style Clam Pizza" };
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(pizzaIngredient) { Name = "New York Style Pepperoni Pizza" };
                    break;
            }
            return pizza;
        }
    }
}
