using System;
using System.Collections.Generic;
using System.Text;

namespace DinerMerge
{
   public interface IMenu
    {
        IIterator CreateIterator();
    }
}
