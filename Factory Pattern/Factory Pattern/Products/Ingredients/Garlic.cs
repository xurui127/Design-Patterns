using Factory_Pattern.Products.Ingredients.Abstructions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern.Products.Ingredients
{
    public class Garlic : IVeggies
    {
       string IVeggies.Tostring()
        {
            return "Garlic";
        }
    }
}
