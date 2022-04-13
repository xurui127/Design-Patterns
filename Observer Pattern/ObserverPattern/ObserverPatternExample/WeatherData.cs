using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Example.WeatherSation
{
   public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;
        public WeatherData()
        {
            observers = new List<IObserver>();
        }
        public void NodifyObserver()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                observers[i].Update(temperature, humidity, pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoverObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void MeasurementsChanged()
        {
            NodifyObserver();
        }

        public void SetMeasurements(float _temperature,float _humidity,float _pressure)
        {
            this.temperature = _temperature;
            this.humidity = _humidity;
            this.pressure = _pressure;
            MeasurementsChanged();
        }
    }
}
