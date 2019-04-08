using System;
namespace _12_first_class_example
{

    //הגדרת תבנית שלא תופסת מקום בפועל בזיכרון
    //אלא מאפשרת ליצור ממנה מופעים לפי הגדרתה
    class Car
    {
        public int NumOfWheels;

        public decimal Price;
    }


    class Program
    {
        static void Main(string[] args)
        {

            //new Car() - this creates in the heap a new object of tha "Car" class
            //and the address of this object is stored to the "myCar1"
            Car myCar1 = new Car();
            myCar1.Price = 1000;
            myCar1.NumOfWheels = 4;

            Console.WriteLine($"Car 1 costs: {myCar1.Price}, and has {myCar1.NumOfWheels} wheels");



            //new Car() - this creates in the heap a new object of tha "Car" class
            //and the address of this object is stored to the "myCar2"
            Car myCar2 = new Car();
            myCar2.Price = 2000;
            myCar2.NumOfWheels = 5;

            Console.WriteLine($"Car 2 costs: {myCar2.Price}, and has {myCar2.NumOfWheels} wheels");

        }
    }
}
