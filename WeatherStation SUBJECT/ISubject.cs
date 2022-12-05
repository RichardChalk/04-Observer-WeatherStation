using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation_OBSERVER
{
    interface ISubject
    {
        // The first 2 methods take an IObserver as a parameter
        public void RegisterObserver(IObserver o);
        public void RemoveObserver(IObserver o);
        
        // This is where we communicate with our observers
        public void NotifyObservers();
    }
}
