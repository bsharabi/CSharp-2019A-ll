using CarRent;
using System;


namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Console.WriteLine(c.Price);  //--> 100
        }
    }
}
