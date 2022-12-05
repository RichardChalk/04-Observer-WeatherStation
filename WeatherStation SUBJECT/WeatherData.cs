using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation_OBSERVER
{
    class WeatherData : ISubject
    {
        // Let's declare a list of all our observers
        private List<IObserver> _observersList;
        // And our data fields
        private float _temperature;
        private float _humidity;
        private float _pressure;

        // In the CTOR we now create our empty list of observers
        public WeatherData()
        {
            _observersList = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            _observersList.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            int index = _observersList.IndexOf(o);
            
            if (index>=0) // if list is not empty
            {
                _observersList.RemoveAt(index);
            }
        }

        // We notify observers when weatherdata changes
        public void NotifyObservers()
        {
            foreach (IObserver observer in _observersList)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        // After changing our measurements this method calls 'NotifyUsers'
        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;
            NotifyObservers();
        }
    }
}
