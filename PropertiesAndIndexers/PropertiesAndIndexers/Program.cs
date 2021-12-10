using System;

namespace PropertiesAndIndexers
{
    class Program
    {
        static void Main(string[] args)
        {
            MyColllectionOfIntegers collection = 
                new MyColllectionOfIntegers(new[] { 1, 2, 3, 4 });

            int min = collection.Min();
            int element = collection[0];

            Address address = new Address();
            address.City = "Oradea";
            address.PostalCode = "123";

            Console.WriteLine(address["city"]);
        }
    }
}
