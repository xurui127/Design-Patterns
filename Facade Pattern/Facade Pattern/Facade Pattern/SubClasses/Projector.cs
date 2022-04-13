using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern.SubClasses
{
   public class Projector
    {
        private string description;

        private DVDPlayer dVDPlayer;
        public Projector(string _description, DVDPlayer _dVDPlayer)
        {
            description = _description;
            dVDPlayer = _dVDPlayer;
        }
        public void On()
        {
            Console.WriteLine($"{description} On");
        }
        public void Off()
        {
            Console.WriteLine($"{description} Off");
        }
        public void WideScreenMode()
        {
            Console.WriteLine($"{description} In WideScreen Mode"); ;
        }
        public void TVMode()
        {
            Console.WriteLine($"{description} In TV Mode");
        }
        public override string ToString()
        {
            return description;
        }
    }
}
