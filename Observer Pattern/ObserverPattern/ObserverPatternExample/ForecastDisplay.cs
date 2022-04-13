using ObserverPattern.Example.WeatherSation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternExample
{
    class ForecastDisplay : IObserver, IDisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine(" Forecast : ");
            if (currentPressure> lastPressure)
            {
                Console.WriteLine("Improving weather  on the way !");
            }
            else if (currentPressure == lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else if (currentPressure <lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
            
        }

        public void Update(float temp, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;
            Display();
        }
    }
}
