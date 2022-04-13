using System;
using System.Collections.Generic;
using System.Text;

namespace DinerMerge
{
   public interface IIterator
    {
        bool HasNext();
        MenuItem Next();
    }
}
