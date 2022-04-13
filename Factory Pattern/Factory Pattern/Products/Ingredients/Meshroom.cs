using Factory_Pattern.Products.Ingredients.Abstructions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern.Products.Ingredients
{
    public class Meshroom : IVeggies
    {
        string IVeggies.Tostring()
        {
            return "Meshroom";
        }
    }
}
