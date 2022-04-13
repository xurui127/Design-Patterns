using System;
using System.Collections.Generic;
using System.Text;

namespace DinerMerge
{
    public class DinerMenuIterator : IIterator
    {
        private MenuItem[] items;
        private int position;

        public DinerMenuIterator(MenuItem[] _items)
        {
            items = _items;
        }
        public bool HasNext()
        {
            return position < items.Length && items[position] != null;
        }

        public MenuItem Next()
        {
            return items[position++];
        }
        
    }
}
