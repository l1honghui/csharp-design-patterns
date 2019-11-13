using System;

namespace observer
{
    public class Orcs : IWeatherObserver
    {
        public void Update(WeatherType currentWeather)
        {
            switch (currentWeather)
            {
                case WeatherType.COLD:
                    Console.WriteLine("The orcs are freezing cold.");
                    break;
                case WeatherType.RAINY:
                    Console.WriteLine("The orcs are dripping wet.");
                    break;
                case WeatherType.SUNNY:
                    Console.WriteLine("The sun hurts the orcs' eyes.");
                    break;
                case WeatherType.WINDY:
                    Console.WriteLine("The orc smell almost vanishes in the wind.");
                    break;
            }
        }
    }
}