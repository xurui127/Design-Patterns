using System;
using System.Collections.Generic;
using System.Text;

namespace Barista
{
    public class CoffeeWithHook : CaffeineBeverageWithHook
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Dripping Coffee Through Filter");
        }

        public override void Brew()
        {
            Console.WriteLine("Adding Sugar And Milk");
        }
        public override bool CustomerWantsCondiments => GetUserInput().ToUpper().StartsWith("Y");
        private string GetUserInput()
        {
            Console.WriteLine("Would You Like Milk And Sugar With Your Coffee(y/n)?");
            string answer = Console.ReadLine();
            
            return answer ?? "no";
        }
    }
}
