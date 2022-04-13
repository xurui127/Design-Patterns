
using Abstruct_Factory_Pattern.Products.Ingredients.Abstructions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstruct_Factory_Pattern.Products.Ingredients
{
    public class Onion : IVeggies
    {
        string IVeggies.Tostring()
        {
            return "Onion";
        }
    }
}
