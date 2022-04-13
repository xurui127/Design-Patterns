using System;
using System.Collections.Generic;
using System.Text;

namespace Chacolate_Factory
{
   public class ChocolateFactory
    {
       

        public bool Empty { get; private set; }
        public bool Boiled { get; private set; }
        private static ChocolateFactory uniqueInstance; 
        private ChocolateFactory()  
        {
            Empty = true;
            Boiled = false;
        }
        public static ChocolateFactory GetInstance()
        {
            if (uniqueInstance == null)
            {
                Console.WriteLine("If instance is null, create an instance");
                uniqueInstance = new ChocolateFactory();
            }
            Console.WriteLine("If instance is not null, return the instance");
            return uniqueInstance;
        }
        public void Fill()
        {
            if (Empty)
            {
                Empty = false;
                Boiled = false;
            }
        }
        public void Drain()
        {
            if (!Empty && Boiled)
            {
                Empty = true;
            }
        }
        public void Boil()
        {
            if (!Empty && !Boiled)
            {
                Boiled = true;
            }
        }

    }
}
