using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControlWithUndo.Receiver
{
    public class Light
    {
        private string location;
        public Light(string _location)
        {
            location = _location;
        }
        public void On() => Console.WriteLine(" Lighting On");
        public void Off() => Console.WriteLine(" Lighting Off");
    }
}
