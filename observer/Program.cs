using System;

namespace observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Weather weather = new Weather();
            weather.AddObserver(new Orcs());
            weather.AddObserver(new Hobbits());

            weather.TimePasses();
            weather.TimePasses();
            weather.TimePasses();
            weather.TimePasses();

        }
    }
}