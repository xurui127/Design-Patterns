using Factory_Pattern.Pizzas.Abstruction;
using System;
using System.Collections.Generic;
using System.Text;

namespace factory_pattern
{
    class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = " chicago style deep dish cheese pizza";
            Dough = " extra thick crust dough";
            Sauce = " plum tomato sauce";

            Topping.Add("shredded mozzarella cheese");

        }

        public override void Cut()
        {
            Console.WriteLine("  cutting the pizza into square slices");
        }
    }
}
