using System;

namespace observer
{
    public class Hobbits : IWeatherObserver
    {
        public void Update(WeatherType currentWeather)
        {
            switch (currentWeather)
            {
                case WeatherType.COLD:
                    Console.WriteLine("The hobbits are shivering in the cold weather.");
                    break;
                case WeatherType.RAINY:
                    Console.WriteLine("The hobbits look for cover from the rain.");
                    break;
                case WeatherType.SUNNY:
                    Console.WriteLine("The happy hobbits bade in the warm sun.");
                    break;
                case WeatherType.WINDY:
                    Console.WriteLine("The hobbits hold their hats tightly in the windy weather.");
                    break;
            }
        }
    }
}