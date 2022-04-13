using Adapter_Pattern.Adapter.Modle.Ducks.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern.Adapters
{
    public class TurkeyAdapter : IDuck
    {
        ITurkey turkey;
        public TurkeyAdapter(ITurkey _turkey)
        {
            turkey = _turkey;
        }
        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.Fly();
            }
        }

        public void Quack()
        {
            turkey.Gobble();
        }
    }
}
