using System;

namespace CarDemo
{
    class CarData
    {
        // Carparts (data)
        public string CarModel { get; set; }
        public string CarPrice { get; set; }
        public string CarColor { get; set; }
        
        // methods (functionality)
        public void Print()
        {
            Console.WriteLine("Carmodel: " + CarModel);
            Console.WriteLine("Carprice: " + CarPrice);
            Console.WriteLine("Carcolor: " + CarColor);
            
        }
    }
}