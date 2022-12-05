using System;

namespace WeatherStation_OBSERVER
{
    class Program
    {
        static void Main(string[] args)
        {
            // ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING -
            // ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING -
            // ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING -
            // ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING -

            // 1. Följ exemplet och skriv koden i denna fil "Observer Design Pattern.pdf"
            // 2. Rita ditt eget UML diagram i Draw.io som beskriver din kod

            // OBS: Exemplet i pdf filen är skriven i Java... du ska så klart skriva i C#!
            // ///////////////////////////////////////////////////////////////////////////
            WeatherData weatherData = new WeatherData();

            CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(25,85,125.1f);
            Console.WriteLine();
            weatherData.SetMeasurements(28, 75, 120.4f);
        }
    }
}
