using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Example.WeatherSation
{
   public interface ISubject
    {
        public void RegisterObserver(IObserver observer);
        public void RemoverObserver(IObserver observer);
        public void NodifyObserver();
    }
}
