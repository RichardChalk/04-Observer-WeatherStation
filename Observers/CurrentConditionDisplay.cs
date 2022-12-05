using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation_OBSERVER
{
    class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;
        private ISubject _weatherData;

        // The CTOR is passed a weatherData object (the subject)
        // so now we can add this wholle class to the observer list of the subject
        public CurrentConditionDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }
       
        // Once we have updated our values we call the display method
        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;
            Display();
        }
        public void Display()
        {
            Console.WriteLine($"Current temp: {_temperature}");
            Console.WriteLine($"Current humidity: {_humidity}");
            Console.WriteLine($"Current pressure: {_pressure}");
        }
    }
}
