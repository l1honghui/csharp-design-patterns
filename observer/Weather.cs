using System;
using System.Collections.Generic;

namespace observer
{
    public class Weather
    {
        private WeatherType _currentWeather;
        private readonly List<IWeatherObserver> _observers;

        public Weather()
        {
            _observers = new List<IWeatherObserver>();
            _currentWeather = WeatherType.SUNNY;
        }

        public void AddObserver(IWeatherObserver obs)
        {
            _observers.Add(obs);
        }

        public void RemoveObserver(IWeatherObserver obs)
        {
            _observers.Remove(obs);
        }

        /**
         * Makes time pass for weather
         */
        public void TimePasses()
        {
            _currentWeather = (WeatherType) new Random().Next((int) WeatherType.COLD + 1);
            Console.WriteLine("The weather changed to {0}.", _currentWeather);
            NotifyObservers();
        }

        private void NotifyObservers()
        {
            foreach (var obs in _observers)
            {
                obs.Update(_currentWeather);
            }
        }
    }
}