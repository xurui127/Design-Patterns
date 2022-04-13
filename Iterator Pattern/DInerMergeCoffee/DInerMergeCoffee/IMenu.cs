using System;
using System.Collections.Generic;
using System.Text;

namespace DinerMergeCoffee
{
    public interface IMenu
    {
        IEnumerator<MenuItem> CreateIterator();
    }
}
