using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation_OBSERVER
{
    interface IObserver
    {
        public void Update(float temp, float humidity, float pressure);
    }
}
