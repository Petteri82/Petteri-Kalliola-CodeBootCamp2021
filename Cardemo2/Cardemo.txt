using System;

namespace CarDemo
{
    class CarData
    {
        static void Main(string[] args)
        {
            CarData first = new();
            first.CarModel = "Audi A3";
            first.CarPrice = "10000";
            first.CarColor = "Black";
        
            first.Print();

            Car second = new();
            first.CarModel = "Bentley";
            first.CarPrice = "100000";
            first.CarColor = "Red";
            
            second.Print();


            
        }

        
    }
}