using System;
using System.Collections.Generic;
using System.Text;

namespace DinerMerge
{
    public class PancakeHouseMenuIterator : IIterator
    {
        private List<MenuItem> items;
        private int position;
        public PancakeHouseMenuIterator(List<MenuItem> _items)
        {
            items = _items;
        }
        public bool HasNext()
        {
            return position < items.Count;
        }

        public MenuItem Next()
        {
            return items[position++];
        }
    }
}
