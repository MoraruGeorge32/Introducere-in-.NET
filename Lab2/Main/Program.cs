using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            // WeatherObject weather = new WeatherObject();
            // Console.WriteLine(weather.constantDay());
            // Console.WriteLine(weather.constantTemperature);
            // Console.WriteLine(weather.numberOfDays);
            // Console.WriteLine(weather.dayNumber);
            Dry weather = new Dry();
            string file1 = "D:\\weather.dat";
            string file2 = "D:\\football.dat";
            string[] split = weather.loadingFile(file1);
            weather.parserInfo(split,"*",1,2);
            weather.constantDay();

            Dry goals = new Dry();
            string[] split2 = goals.loadingFile(file2);
            goals.parserInfo(split2,"-",6,8);
            goals.weakestTeam();



        }
    }
}
