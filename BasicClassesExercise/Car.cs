using System;
using System.Collections.Generic;
using System.Text;

namespace BasicClassesExercise
{
    public class Car
    {
        public Car()
        {

        }
        public Car(string Make)
        {
            Make = Make;
  
        }
     
        public Car(int Year)

        {
            Year = Year;
        }

        public Car(string Model, bool IsTheLatestModel)
        {
            Model = Model;
            IsTheLatestModel = IsTheLatestModel;
        }

        int year;
        public string Model {get; set;}
        public bool IsTheLatestModel { get; set;}
        public string Make {get; set;}
        public int Year {get; set;}
       
        public void MyNewCar()
        {
            Console.WriteLine($"My New Car is a {Year} {Make} {Model}, it {IsTheLatestModel}!");
        }
    }
}



