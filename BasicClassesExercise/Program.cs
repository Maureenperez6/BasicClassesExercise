using System;
using System.Collections.Generic;

namespace BasicClassesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var toyota = new Car(); 
            toyota.Year = 2021;
            toyota.Make = "Toyota";
            toyota.Model = "4Runner";

            Console.WriteLine($"{toyota.Year} {toyota.Make} {toyota.Model}");

        }
    }
}
