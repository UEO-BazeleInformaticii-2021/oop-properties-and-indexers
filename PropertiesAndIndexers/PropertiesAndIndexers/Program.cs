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
        }
    }
}
