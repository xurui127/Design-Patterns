using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DinerMergeCoffee
{
    public class DinerMenuIterator : IEnumerator<MenuItem>
    {
        private IEnumerator enumerator;
        public MenuItem Current => (MenuItem)enumerator.Current;

        object IEnumerator.Current => Current;

        public DinerMenuIterator(MenuItem[] _menuItems)
        {
            enumerator = _menuItems.GetEnumerator();
        }
        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return enumerator.MoveNext();
        }

        public void Reset()
        {
            enumerator.Reset();
        }
    }
}
