using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern.SubClasses
{
  public  class DVDPlayer
    {
        private string description;
        private Amplifier amplifier;
        private string movie;
        private int currentTrack;

        public DVDPlayer(string _description, Amplifier _amplifer)
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
            movie = null;
            Console.WriteLine($"{description} Ejected");
        }
        public void Play(string _title)
        {
            movie = _title;
            currentTrack = 0;
            Console.WriteLine($"{description} Playing \"{movie}\"");
        }
        public void Play(int _track)
        {
            if (movie == null)
            {
                Console.WriteLine($"{description} Can Not Play Track {currentTrack.ToString()},No DVD");
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
            Console.WriteLine($"{ description} Paused \"{movie} \"");

        }
        public void SetTwoChannelAudio()
        {
            Console.WriteLine($"{description} Set Two Channel Audio");
        }
        public void SetSurrounAudio()
        {
            Console.WriteLine($"{description} Set Surround Audio");
        }
        public override string ToString()
        {
            return description;
        }
    }
}

