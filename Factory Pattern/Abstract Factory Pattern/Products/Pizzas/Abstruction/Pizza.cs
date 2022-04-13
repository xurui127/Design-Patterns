
using Abstruct_Factory_Pattern.Products.Ingredients.Abstructions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstruct_Factory_Pattern.Pizzas.Abstruction
{
    public abstract class Pizza
    {
       public string Name { get; set; }

        public IDough Dough { get;  set; }
        public ICheese Cheese { get;  set; }
        public IClams Clams { get;  set; }
        public IPepperoni Pepperoni { get;  set; }
        public IVeggies[] Veggies { get;  set; }
        public ISauce Sauce { get;  set; }





        public abstract void Prepare();
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
            if (Dough != null)
            {
                result.AppendLine(Dough.Tostring());
            }
            if (Sauce != null)
            {
                result.AppendLine(Sauce.Tostring());
            }
            if (Cheese != null)
            {
                result.AppendLine(Cheese.Tostring());
            }
            if (Veggies != null)
            {
                for (int i = 0; i < Veggies.Length; i++)
                {
                    result.Append(Veggies[i].Tostring());
                    if (i < Veggies.Length - 1)
                    {
                        result.Append(", ");
                    }
                }
                result.Append("\n");
            }
            if (Clams != null)
            {
                result.AppendLine(Clams.Tostring());
            }
            if (Pepperoni != null)
            {
                result.AppendLine(Pepperoni.Tostring());
            }
            return result.ToString();
        }

    }
}
