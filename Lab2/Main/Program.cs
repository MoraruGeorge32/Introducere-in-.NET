using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherObject weather = new WeatherObject();
            Console.WriteLine(weather.constantDay());
            Console.WriteLine(weather.constantTemperature);
            Console.WriteLine(weather.numberOfDays);
            Console.WriteLine(weather.dayNumber);
        }
    }
}
