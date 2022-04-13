using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl.Receiver
{
    public class Stereo
    {
        private string location;

        public Stereo(string _location)
        {
            location = _location;
        }
        public void On() => Console.WriteLine(location + "Stereo On");
        public void Off() => Console.WriteLine(location + "Stereo Off");
        public void SetCD() => Console.WriteLine(location + "Stereo Set CD");
        public void SetDVD() => Console.WriteLine(location + "Stereo SetDVD");
        public void SetRadio() => Console.WriteLine(location + "Stereo SetRadio");
        public void SetVolume() => Console.WriteLine(location + "Stereo SetVolume");
    }
}
