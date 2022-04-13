using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControlWithUndo.Receiver
{
   public class CeilingFan
    {
        private string location;
        public const int high = 3;
        public const int medium = 2;
        public const int low = 1;
        public const int off = 0;
        private int speed;
        public CeilingFan(string _location)
        {
            location = _location;
        }
        public void High()
        {
            speed = high;
            Console.WriteLine("Ceiling Fan Turn to High");
        }
        public void Medium()
        {
            speed = medium;
            Console.WriteLine("Ceiling Fan Turn to Medium");

        }
        public void Low()
        {
            speed = low;
            Console.WriteLine("Ceiling Fan Turn to Low");
        }
        public void Off()
        {
            speed = off;
            Console.WriteLine("Ceiling Fan Turn to Off");
        }
        public int GetSpeed() => speed;
    }
}
