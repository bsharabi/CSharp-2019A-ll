using System;
namespace task_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Person barak = new Person();
            barak.Name = "barak";
            barak.Address_n = new Address("israel","ariel","shshet hayamim",15);
            barak.getInfo();
            Console.WriteLine( $"{barak.Address_n.Country}" ); 

        }
    }
}
