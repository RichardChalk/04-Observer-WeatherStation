using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation_OBSERVER
{
    class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float _maxTemp = 0.0f;
        private float _minTemp = 200;//set intial high so that minimum 
                                    //is set first invokation
        private float _temperatureSum = 0.0f;
        private int _numReadings = 0;
        private ISubject _weatherData;

        public int NumberOfReadings
        {
            get
            {
                return _numReadings;
            }
        }

        public StatisticsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }


        public void Update(float temp, float humidity, float pressure)
        {
            _temperatureSum += temp;
            _numReadings++;

            if (temp > _maxTemp)
            {
                _maxTemp = temp;
            }

            if (temp < _minTemp)
            {
                _minTemp = temp;
            }
            Display();
        }
        public void Display()
        {
            Console.WriteLine("Average temp: " + (_temperatureSum / _numReadings) + " max temp: " + _maxTemp + " min temp: " + _minTemp);
        }
    }
}
