using System; 
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    public class AlternatingDinerMenuIterator : IIterator
    {
        MenuItem[] menuItems;
        int position;
        public AlternatingDinerMenuIterator(MenuItem[] _menuItems)
        {
            this.menuItems = _menuItems;
            position = (int)DateTime.Now.DayOfWeek % 2;
        }
        public bool HasNext()
        {
            if (position >= menuItems.Length || menuItems[position]==null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public MenuItem Next()
        {
            MenuItem items = menuItems[position];
            position = position + 2;
            return items;
        }

        public void Remove()
        {
            throw new NotImplementedException("Alternating Diner Menu Iterator does not support return ()");
        }
    }
}
