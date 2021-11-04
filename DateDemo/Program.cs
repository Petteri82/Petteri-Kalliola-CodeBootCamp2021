using System;

namespace DateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // read the dates from the user
            Console.WriteLine("Anna päivämäärä 1:");
            string value = Console.ReadLine();
            // int number = int.Parse(value);
            DateTime date1 = DateTime.Parse(value);

            Console.WriteLine("Anna toinen päivämäärä :");
            string value = Console.ReadLine();
            int number = int.Parse(value);
            DateTime date2 = DateTime.Parse(value);

            // date calculations
            TimeSpan difference = date2 - date1;
            Console.WriteLine("Difference in days: " + differance.TotalDays);
            Console.WriteLine("Difference in hours: " + differance.TotalDays);
            
            

        }
    }
    
}

