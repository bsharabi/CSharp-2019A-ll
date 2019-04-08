using System;

namespace _00_accesss
{ 


    class Program
    {
        static void Main(string[] args)
        {

            //new Car() - this creates in the heap a new object of tha "Car" class
            //and the address of this object is stored to the "myCar1"
            Car myCar1 = new Car();

            myCar1.SetNumOfWheels(4);



            Console.WriteLine($"myCar1 has {myCar1.GetNumOfWheels()}");
            Console.WriteLine(myCar1.GetDescription());



            //new Car() - this creates in the heap a new object of tha "Car" class
            //and the address of this object is stored to the "myCar2"
            Car myCar2 = new Car();
            myCar2.SetNumOfWheels(5);

            Console.WriteLine($"myCar2 has {myCar2.GetNumOfWheels()}");

            Console.WriteLine(myCar2.GetDescription());

        }
    }
}