using Adapter_Pattern.Adapter.Modle.Ducks.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern.Adapter.Modle.Ducks
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
             Console.WriteLine("I'm Flying");
            
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
