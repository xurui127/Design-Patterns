using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern.SubClasses
{
  public  class Amplifier
    {
        private string description;
        public Tuner Tuner { get; private set; }
        public CDPlayer cDPlayer { get; private set; }
        public DVDPlayer dVDPlayer { get; private set; }
        public Amplifier(string _discription)
        {
            description = _discription;
        }
        public void On()
        {
            Console.WriteLine($"{description} On");
        } 
        public void Off()
        {
            Console.WriteLine($"{description} Off");
        }
        public void SetStereoSound()
        {
            Console.WriteLine($"{description} Stereo On");
        }
        public void SetSurroundSound()
        {
            Console.WriteLine($"{description} Surround Sound On (5 Speakers, 1 Subwoofer)");
        }
        public void SetVolum(int _level)
        {
            Console.WriteLine($"{description} Setting Volume To {_level.ToString()}");
        }
        public void SetTuner(Tuner _tuner)
        {
            Console.WriteLine($"{description} Setting Tunner To {_tuner}");
            Tuner = _tuner;
        }
        public void SetCD(CDPlayer _cDPlayer)
        {
            Console.WriteLine($"{description} Setting CD Player To {_cDPlayer}");
            cDPlayer = _cDPlayer;
        }
        public void SetDVD(DVDPlayer _dVDPlayer)
        {
            dVDPlayer = _dVDPlayer;
            Console.WriteLine($"{description} Set DVD PLayer To {_dVDPlayer}");
        }
        public override string ToString()
        {
            return description;
        }
    }
}
