using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl.Receiver
{
    public class Light
    {
        private string location;
        public Light(string _location)
        {
            location = _location;
        }
        public void On() => Console.WriteLine(location + " Lighting On");
        public void Off() => Console.WriteLine(location + " Lighting Off");
    }
}
