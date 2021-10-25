using System;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer first = new();
            first.Name = "Jane Doe";
            first.Address = "Winterfell 123";
            first.Zipcode = "74992";
            first.City = "Vaasa";
            first.Print();

            Customer second = new();
            first.Name = "Jane Doe";
            first.Address = "Winterfell 123";
            first.Zipcode = "74992";
            first.City = "Vaasa";
            first.print();
        
            // Console.WriteLine("Hello World!");
        }
    }
}
