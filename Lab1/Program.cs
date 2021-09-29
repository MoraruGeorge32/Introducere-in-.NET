using System;
using ExtensionMethods;
namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(100,"Mihai","Alexandru", new DateTime(2012,5,1), new DateTime(2021,9,29), 1500);
            Architect architect = new Architect(101,"George","Iosif", new DateTime(2020, 4, 1), new DateTime(2012,5,1), 2500);
            string salutation = manager.salutation();
            string salutation2 = architect.salutation();
            Console.WriteLine(manager.getFullName());
            Console.WriteLine(architect.getFullName());
            Console.WriteLine(salutation);
            Console.WriteLine(salutation2);
            string s = "I have 5 words here!";
            int i = s.WordCount();
            string[] array = s.WordArray();
            Console.WriteLine(i);
            foreach(var j in array) 
                Console.Write(j+" ");
        }
    }
}