using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
   public interface IIterator
    {
        bool HasNext();
        MenuItem Next();
        public void Remove();
    }
}
