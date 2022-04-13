using Factory_Pattern.Products.Ingredients.Abstructions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern.Products.Ingredients
{
    public class ThinCrustDough : IDough
    {
        string IDough.Tostring()
        {
            return "Thin Crust Dough";
        }
    }
}
