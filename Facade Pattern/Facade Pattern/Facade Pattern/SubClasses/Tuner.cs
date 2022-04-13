using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Facade_Pattern.SubClasses
{
   public class Tuner
    {
        private string description;
        private Amplifier amplifier;
        private double frequency;

        public Tuner(string _description, Amplifier _amplifier)
        {
            description = _description;
            amplifier = _amplifier;
        }

        public void On()
        {
            Console.WriteLine($"{description} On");
        } 
        public void Off()
        {
            Console.WriteLine($"{description} Off");
        }
        public void SetFrequency(double _frequency)
        {
            Console.WriteLine($"{description} Setting Frequence To {frequency.ToString(CultureInfo.InvariantCulture)}");
        }
        public void SetAm()
        {
            Console.WriteLine($"{description} Setting AM Mode");
        }
        public void SetFM()
        {
            Console.WriteLine($"{description} Settomh FM Mode");
        }
        public override string ToString()
        {
            return description;
        }

    }
}
