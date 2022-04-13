using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription()+ " $ " + beverage.Cost());

            Beverage houseBlend = new HouseBlend();
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Soya(houseBlend);

            Console.WriteLine(houseBlend.GetDescription() + " $ " + houseBlend.Cost());
            
            Beverage darkRoast = new DarkRoast();
            darkRoast = new Soya(darkRoast);
            Console.WriteLine(darkRoast.GetDescription() + " $ " + darkRoast.Cost());

            
        }
    }
}
