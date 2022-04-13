using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Final_.Receiver
{
   public class Hottub
    {
        private bool on;
        private int temperature;

        public void On()
        {
            on = true;
            Console.WriteLine("Hottub Is On");
        }  public void Off()
        {
            on = true;
            Console.WriteLine("Hottub Is Off");
        }

        public void Circulate()
        {
            if (on)
            {
                Console.WriteLine("Hottub is Circulating");
            }
        }
        public void JetOn()
        {
            if (on)
            {
                Console.WriteLine("Hottub is Jet On");
            }
        }
        public void JetOff()
        {
            if (on)
            {
                Console.WriteLine("Hottub is Jet Off");
            }
        }
        public void SetTemperature( int _temperature)
        {
            if (temperature <_temperature)
            {
                Console.WriteLine("Hottub is heating to " + temperature +"degrees");
            }
            else
            {
                Console.WriteLine("Hottub is cooling to " + temperature + "degrees");
            }
            temperature = _temperature;
        }
    }
}
