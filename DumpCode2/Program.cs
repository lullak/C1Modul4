using System.Reflection.Metadata;
using System;

namespace DumpCode2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Create a simple C# program that calculates the average temperature from an array of temperatures. The program should:
        //Declare a method CalculateAverage that takes an array of doubles as a parameter.
        //Implement the method to calculate the average of the temperatures in the array.
        //Declare a method PrintAverage that takes an array of doubles as a parameter.
        //Implement the method to call CalculateAverage and print the result to the console.
        //Alert!
        //The result of execution for the default string should be:
        //"The average temperature is: 23.5"
        }

        public void PrintAverage(double[] temperatures)
        {
            Console.WriteLine($"The average temperature is: {CalculateAverage(temperatures)}");
        }

        public double CalculateAverage(double[] temperatures)
        {
            double avgTemp = 0.0;
            foreach (double d in temperatures)
            {
                avgTemp += d;
            }
            avgTemp /= temperatures.Length;
            return avgTemp;
        }
    }
}
