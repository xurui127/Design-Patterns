using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    public class NullIterator : IEnumerator<MenuItem>
    {
        public MenuItem Current => null;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
        }
    }
}
