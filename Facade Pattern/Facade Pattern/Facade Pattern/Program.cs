using Facade_Pattern.Facade;
using Facade_Pattern.SubClasses;
using System;

namespace Facade_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var amp = new Amplifier("Amplifier");
            var tuner = new Tuner("Tuner", amp);
            var dvd = new DVDPlayer("DVD", amp);
            var cd = new CDPlayer("Dvd", amp);
            var projector = new Projector("Projector", dvd);
            var lights = new TheaterLights("Theater Lights");
            var screen = new Screen("Theater Screen");
            var poper = new PopcornPopper("Popcorn Popper");

            var homeTheater = new HomeTheaterFacade(amp,tuner,projector,lights,screen,poper,dvd,cd);
            homeTheater.WatchMovie("AAA");
            homeTheater.EndMovie();
        }
    }
}
