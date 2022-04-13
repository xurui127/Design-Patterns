using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Final_.Receiver
{
    public class TV
    {
        private string location;
        private int channel;

        public TV(string _location)
        {
            location = _location;
        }
        public void On() => Console.WriteLine(location + "TV Is On");
        public void Off() => Console.WriteLine(location + "TV Is Off");

        public void SetInputChannel()
        {
            channel = 1;
            Console.WriteLine(location + "TV channel is Sports");
        }
    }
}
