using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
   public class Tasks : IObserver
    {
        public void Update(Object obeject)
        {
            OverRideUpdate(obeject);
        }

        protected virtual void OverRideUpdate(Object obeject) { }
    }
    class Task1 : Tasks
    {
        protected override void OverRideUpdate(Object obeject)
        {
            Console.WriteLine("Task1 Receive : " + obeject);
        }
    }
    class Task2 : Tasks
    {
        protected override void OverRideUpdate(Object obeject)
        {
            Console.WriteLine("Task2 Receive : " + obeject);
        }
    }
}
