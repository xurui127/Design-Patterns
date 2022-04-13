using System;
using System.Collections.Generic;
using System.Text;

namespace Barista
{
    public class TeaWithHook : CaffeineBeverageWithHook
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Steeping The Tea");
        }
        public override bool CustomerWantsCondiments => GetUserInput().ToUpper().StartsWith("Y");
        private string GetUserInput()
        {
            Console.WriteLine("Would You Like Lemon With Your Tea(y/n)?");
            string answer = Console.ReadLine();

            return answer ?? "no";
        }
    }
}
