using Adapter_Pattern.Adapter.Modle.Ducks.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern.Adapter.Modle.Ducks
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying in a short distance");
        }

        public void Gobble()
        {
            Console.WriteLine("I'm gobble");
        }
    }
}
