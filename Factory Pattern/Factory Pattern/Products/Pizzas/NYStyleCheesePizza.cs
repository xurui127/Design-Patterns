using Factory_Pattern.Pizzas.Abstruction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = " NY Style Sauce and Cheese Pizza";
            Dough = " Thin Crust Dough";
            Sauce = " Marinara Sauce";

            Topping.Add("Grated Reggino Cheese");
        }
    }
}
