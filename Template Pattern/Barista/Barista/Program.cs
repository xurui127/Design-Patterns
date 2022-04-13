using System;

namespace Barista
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();
            Console.WriteLine("Tea Making...");
            tea.PrepareRecipe();

            Coffee coffee = new Coffee();
            Console.WriteLine("Coffee Making....");
            coffee.PrepareRecipe();


            CoffeeWithHook coffeeWithHook = new CoffeeWithHook();
            Console.WriteLine("Coffee With Hook ....");
            coffeeWithHook.PrepareRecipe();

            TeaWithHook teaWithHook = new TeaWithHook();
            Console.WriteLine("Tea With Hook...");
            teaWithHook.PrepareRecipe();
        }
    }
}
