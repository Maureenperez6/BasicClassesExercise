using System;
using System.Collections.Generic;

namespace BasicClassesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.IsTheLatestModel = true;
            myCar.Make = "Toyota";
            myCar.Model = "4Runner";
            myCar.Year = 2021;

            myCar.MyNewCar();



        }
    }
}
