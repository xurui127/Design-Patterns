using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
   public abstract class MenuComponent
    {
        public virtual string name { get { throw new NotImplementedException(); } }
        public virtual string description { get { throw new NotImplementedException(); } }
        public virtual double price { get { throw new NotImplementedException(); } }
        public virtual bool isVegetarian { get { throw new NotImplementedException(); } }

        public abstract IEnumerator<MenuComponent> CreateIterator();

     
      public virtual void Add(MenuComponent _menuComponent)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(MenuComponent _menuComponent)
        {
            throw new NotImplementedException();
        }
        public virtual MenuComponent GetChild(int i)
        {
            throw new NotImplementedException();
        }
        public virtual void Print()
        {
            throw new NotImplementedException();
        }
        
    }
}
