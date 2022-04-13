
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern.SubClasses
{
   public class CDPlayer
    {
        private string description;
        private Amplifier amplifier;
        private string title;
        private int currentTrack;

        public CDPlayer(string _description, Amplifier _amplifer)
        {
            description = _description;
            amplifier = _amplifer;
        }
        public void On()
        {
            Console.WriteLine($"{description} On");
        }
        public void Off()
        {
            Console.WriteLine($"{description} Off");
        }
        public void Eject()
        {
            title = null;
            Console.WriteLine($"{description} Ejected");
        }
        public void Play(string _title)
        {
            title = _title;
            currentTrack = 0;
            Console.WriteLine($"{description} Playing \"{title}\"");
        }
        public void Play(int _track)
        {
            if (title ==null)
            {
                Console.WriteLine($"{description} Can Not Play Track {currentTrack.ToString()},No CD");
            }
            else
            {
                currentTrack = _track;
                Console.WriteLine($"{description} Playing Track {currentTrack.ToString()}");
            }
        }
        public void Stop()
        {
            currentTrack = 0;
            Console.WriteLine($"{ description} Stopped");
        }
        public void Pause()
        {
            Console.WriteLine($"{ description} Paused \"{title} \"");

        }
        public override string ToString()
        {
            return description;
        }
    }
}
