using System;

namespace _00_accesss
{ 


    class Program
    {
        static void Main(string[] args)
        {
            
            Car myCar1 = new Car();

            //set the private property via public property
            myCar1.NumOfWheels = 4;

            //get the private property via public property
            Console.WriteLine($"myCar1 has {myCar1.NumOfWheels}");
        }
    }
}