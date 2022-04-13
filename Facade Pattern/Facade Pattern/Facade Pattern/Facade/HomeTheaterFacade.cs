using Facade_Pattern.SubClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern.Facade
{
    public class HomeTheaterFacade
    {
        private Amplifier amplifier;
        private Tuner tuner;
        private Projector projector;
        private DVDPlayer dVDPlayer;
        private CDPlayer cDPlayer;
        private TheaterLights theaterLights;
        private Screen screen;
        private PopcornPopper popcornPopper;

        public HomeTheaterFacade(Amplifier _amplifier, Tuner _tuner,
                                  Projector _projector, TheaterLights _theaterLights,
                                 Screen _screen, PopcornPopper _popcornPopper,
                                 DVDPlayer _dVDPlayer,CDPlayer _cDPlayer)
        {
            amplifier = _amplifier;
            tuner = _tuner;
            projector = _projector;
            theaterLights = _theaterLights;
            screen = _screen;
            popcornPopper = _popcornPopper;
            dVDPlayer = _dVDPlayer;
            cDPlayer = _cDPlayer;
            
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Watch Movie");
            popcornPopper.On();
            popcornPopper.Pop();
            theaterLights.Dim(10);
            screen.Down();
            projector.On();
            projector.WideScreenMode();
            amplifier.On();
            amplifier.SetDVD(dVDPlayer);
            amplifier.SetSurroundSound();
            amplifier.SetVolum(5);
            dVDPlayer.On();
            dVDPlayer.Play(movie);
        }
        public void EndMovie()
        {
            Console.WriteLine("Shutting Down Movie...");
            popcornPopper.Off();
            theaterLights.On();
            screen.Up();
            projector.Off();
            amplifier.Off();
            dVDPlayer.Stop();
            dVDPlayer.Eject();
            dVDPlayer.Off();
        }
        public void ListenCD(string cdTitle)
        {
            Console.WriteLine("Listen CD");
            theaterLights.On();
            amplifier.On();
            amplifier.SetVolum(5);
            amplifier.SetCD(cDPlayer);
            amplifier.SetStereoSound();
            cDPlayer.On();
            cDPlayer.Play(cdTitle);
        }
        public void EndCD()
        {
            Console.WriteLine("Shutting Down CD....");
            amplifier.Off();
            amplifier.SetCD(cDPlayer);
            cDPlayer.Eject();
            cDPlayer.Off();
        }
        public void ListenToRadio(double frequency)
        {
            Console.WriteLine("Listen Radio...");
            tuner.On();
            tuner.SetFrequency(frequency);
            amplifier.On();
            amplifier.SetVolum(5);
            amplifier.SetTuner(tuner);
        }
        public void EndRadio()
        {
            Console.WriteLine("Shutting Down Tuner");
            tuner.Off();
            amplifier.Off();
        }
    }
}
