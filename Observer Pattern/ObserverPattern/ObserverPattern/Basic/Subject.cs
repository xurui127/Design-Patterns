using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
     public class Subject
    {
        // Container
        List<Tasks> container = new List<Tasks>();
        // Regist
        public void RegisterObserver(Tasks task)
        {
            container.Add(task);
        }

        // UnRegist
        public void UnRegisterObserver(Tasks task)
        {
            container.Remove(task);
        }
        //Notify
        public void NotifyObserver(Object item)
        {
            for (int i = 0; i < container.Count; i++)
            {
                container[i].Update(item);
            }
        }
    }
}
