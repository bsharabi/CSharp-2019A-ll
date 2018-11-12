using System;
namespace _13_class_and_method
{

    //הגדרת תבנית שלא תופסת מקום בפועל בזיכרון
    //אלא מאפשרת ליצור ממנה מופעים לפי הגדרתה
    class Car
    {

        //-------------Properties--------------
        public int NumOfWheels;

        public decimal Price;

        //-------------Methods--------------
        public string GetDescription()
        {
            return $"Car costs: {Price}, and has {NumOfWheels} wheels";
        }
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

            Console.WriteLine(myCar1.GetDescription());



            //new Car() - this creates in the heap a new object of tha "Car" class
            //and the address of this object is stored to the "myCar2"
            Car myCar2 = new Car();
            myCar2.Price = 2000;
            myCar2.NumOfWheels = 5;

            Console.WriteLine(myCar2.GetDescription());

        }
    }
}
