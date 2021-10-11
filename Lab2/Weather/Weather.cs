using System;
using System.IO;
namespace Weather
{
    class WeatherObject
    {   
        private int[] temperatures=new int[200];
        private int dayNumber;
        private int numberOfDays;
        private int constantTemperature;
        public WeatherObject(){
            int nrOfRows=0;
            this.dayNumber=0;
            this.constantTemperature=1000;
            StreamReader input = new StreamReader("D:\\weather.dat",System.Text.Encoding.Default);
            string contents = input.ReadToEnd().Trim();
            string[] split = contents.Split('\n',StringSplitOptions.RemoveEmptyEntries);
            for(int index=1; index<split.Length-1; index++){
                string[] row = split[index].Split(' ',StringSplitOptions.RemoveEmptyEntries);
                if(row[1].Contains("*"))
                    row[1]=row[1].Replace("*",String.Empty);
                if(row[2].Contains("*"))
                    row[2]=row[2].Replace("*",String.Empty);
                int differenceOfTemperature=Int32.Parse(row[1])-Int32.Parse(row[2]);
                this.temperatures[nrOfRows++]=differenceOfTemperature;
            }
            this.numberOfDays=nrOfRows;
        }
        public void constantDay(){
            constantTemperature=this.temperatures[0];
            dayNumber=1;
            for(int index=1; index<this.numberOfDays; index++){
                if(this.temperatures[index]<constantTemperature)
                {
                    constantTemperature=this.temperatures[index];
                    dayNumber=index+1;
                }
            }
            Console.WriteLine("The smallest temperature spread and its day number: " + constantTemperature + " " + dayNumber);
        }
    }
}
