using System;

namespace Chacolate_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateFactory boiler = ChocolateFactory.GetInstance();
            boiler.Fill();
            boiler.Boil();
            boiler.Drain();


            ChocolateFactory boiler2 = ChocolateFactory.GetInstance();
        }
    }
}
