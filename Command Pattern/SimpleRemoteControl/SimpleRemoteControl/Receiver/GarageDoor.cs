using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleRemoteControl.Receiver
{
    public class GarageDoor
    {
        public void Up() => Console.WriteLine("Garage Door is Open");
        public void Down() => Console.WriteLine("Garage Door is Closed");
        public void Stop() => Console.WriteLine("Garage Door is Stop");
        public void LightOn() => Console.WriteLine("Garage Door is LightOn");
        public void LightOff() => Console.WriteLine("Garage Door is LightOff");

    }
}
