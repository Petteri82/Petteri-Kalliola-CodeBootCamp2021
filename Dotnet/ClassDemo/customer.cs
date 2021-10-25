using System;

namespace ClassDemo
    {
        class Customer
        {
            public string Name { get; set; }
            public string Address { get; set; }

            public string Zipcode { get; set; }

            public string City { get; set; }

         }

        public void Print();
        {
        console.WriteLine("Customer Name: " + Name);
        console.WriteLine("Customer Address: " + Address);
        console.WriteLine("Customer Zipcode: " + Zipcode);
        console.WriteLine("Customer City: " + City);

        }   
    }