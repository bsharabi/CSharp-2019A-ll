using System;
namespace _00_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------p1-------------");
            Person p1;
            
            p1= new Person();

            p1.Name = "Bob";
            p1.Age = 60;


            Console.WriteLine(p1.GetDescription());

            Console.WriteLine("---------------------p2-------------");
            Person p2= new Person();

            Console.WriteLine("---------------------p3-------------");
            Person p3 = new Person();
        }
    }
}
