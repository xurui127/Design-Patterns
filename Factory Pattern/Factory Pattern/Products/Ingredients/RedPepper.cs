using Factory_Pattern.Products.Ingredients.Abstructions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern.Products.Ingredients
{
    class RedPepper : IVeggies
    {
        string IVeggies.Tostring()
        {
            return "Red Pepper";
        }
    }
}
