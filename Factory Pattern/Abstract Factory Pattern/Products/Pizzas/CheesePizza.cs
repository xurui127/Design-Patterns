
using Abstruct_Factory_Pattern.AbstructFactory;
using Abstruct_Factory_Pattern.Pizzas.Abstruction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstruct_Factory_Pattern.Pizzas
{
    public class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory pizzaIngredientFactory;

        public CheesePizza(IPizzaIngredientFactory _pizzaIngredientFactory)
        {
            pizzaIngredientFactory = _pizzaIngredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = pizzaIngredientFactory.CreateDough();
            Sauce = pizzaIngredientFactory.CreateSauce();
            Cheese = pizzaIngredientFactory.CreateCheese();

        }
    }
}
