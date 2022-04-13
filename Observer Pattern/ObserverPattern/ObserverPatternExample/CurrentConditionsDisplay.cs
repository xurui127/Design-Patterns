using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Example.WeatherSation
{
   public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private WeatherData weatherData;
        public CurrentConditionsDisplay(WeatherData _weatherData)
        {
            this.weatherData = _weatherData;
            _weatherData.RegisterObserver(this);
        }
        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }
        public void Display()
        {
            Console.WriteLine("Current consitions : " + temperature + "F defress and " +
                humidity + "% humidity");
        }
    }
}
