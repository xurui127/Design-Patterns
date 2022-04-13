using Factory_Pattern.Products.Ingredients;
using Factory_Pattern.Products.Ingredients.Abstructions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern.AbstructiFactory
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
          
            return new ReggianoCheese();
        }

        public IClams CreateClam()
        {
            return new FreshClams();
        }

        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new MarinaaSauce();
        }

        public IVeggies[] CreateVeggies()
        {

            IVeggies[] veggies = { new Garlic(), new Onion(), new Meshroom(), new RedPepper() };
            return veggies;
        }
    }
}
