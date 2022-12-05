using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation_OBSERVER
{
    class ForecastDisplay : IObserver, IDisplayElement
    {
		private float currentPressure = 29.92f;
		private float lastPressure;
		private ISubject _weatherData;

		public ForecastDisplay(ISubject weatherData)
		{
			_weatherData = weatherData;
			_weatherData.RegisterObserver(this);
		}

		
		public void Update(float temperature, float humidity, float pressure)
		{
			lastPressure = currentPressure;
			currentPressure = pressure;
			Display();
		}

		
		public void Display()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("Forecast: ");

			if (currentPressure > lastPressure)
			{
				sb.Append("Improving weather on the way!");
			}
			else if (currentPressure == lastPressure)
			{
				sb.Append("More of the same");
			}
			else if (currentPressure < lastPressure)
			{
				sb.Append("Watch out for cooler, rainy weather");
			}
            Console.WriteLine(sb);
		}
    }
}
