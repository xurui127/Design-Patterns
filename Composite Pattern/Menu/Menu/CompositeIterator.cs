using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu
{
    public class CompositeIterator : IEnumerator<MenuComponent>
    {
        private IEnumerator<MenuComponent> iterator;
        private Stack<IEnumerator<MenuComponent>> stack = new Stack<IEnumerator<MenuComponent>>();
        private MenuComponent current;
        public MenuComponent Current => current;

        object IEnumerator.Current => Current;
        public CompositeIterator(IEnumerator<MenuComponent> _iterator)
        {
            iterator = _iterator;
            stack.Push(iterator);
        }
        public void Dispose()
        {
           
        }

        public bool MoveNext()
        {
            if (!stack.Any())
            {
                current = null;
                return false;
            }
            var iterator = stack.Peek();
            if (!iterator.MoveNext())
            {
                stack.Pop();
                return MoveNext();
            }
            current = iterator.Current;
            if (current is Menus)
            {
                stack.Push(current.CreateIterator());
            }
            return true;
        }

        public void Reset()
        {
            current = null;
            stack.Clear();
            stack.Push(iterator);
        }
    }
}
