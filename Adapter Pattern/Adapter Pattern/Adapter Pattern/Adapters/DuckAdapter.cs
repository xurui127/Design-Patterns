using Adapter_Pattern.Adapter.Modle.Ducks.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern.Adapters
{
    public class DuckAdapter : ITurkey
    {
        private IDuck duck;

        public DuckAdapter(IDuck _duck)
        {
            duck = _duck;
        }
        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                duck.Fly();
            }
        }

        public void Gobble()
        {
            duck.Quack();
        }

    }
}
