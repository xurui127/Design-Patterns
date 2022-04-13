using ObserverPattern.Example.WeatherSation;
using System;

namespace ObserverPatternExample
{
    class WeatherStation
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            weatherData.SetMeasurements(80, 64, 30.5f);
            weatherData.SetMeasurements(82, 70, 29.5f);
            weatherData.SetMeasurements(79, 61, 20.5f);
        }
    }
}
