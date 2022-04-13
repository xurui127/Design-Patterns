using Factory_Pattern.Products.Ingredients.Abstructions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern.Pizzas.Abstruction
{
    public abstract class Pizza
    {
       public string Name { get; set; }

     public string Dough { get; protected set; }
        public string Sauce { get; protected set; }
        public List<string> Topping { get; protected set; } = new List<string>();





        public virtual void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding Toppings");

            foreach (var item in Topping)
            {
            Console.WriteLine("   " + item);

            }
        }
       public virtual void Bake()
        {
            Console.WriteLine("  Bake for 25 mins at 350");
        }
        public virtual void Cut()
        {
            Console.WriteLine("  Cutting the pizza into diagonal slices");
        }
        public virtual void Box()
        {
            Console.WriteLine("  Place pizza in official PizzaStore box");
        }
        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine("---- " + Name + " ----");
            result.AppendLine(Dough);
            result.AppendLine(Sauce);
            foreach (var item in Topping)
            {
                result.AppendLine(item);
            }
            return result.ToString();
        }

    }
}
