using System;

namespace _08_functions
{
    class Program
    {

        static void Main(string[] args)
        {


            PrintHello();

            PrintSum(3, 4);

            string str = GetHello();
            Console.WriteLine($"Got from GetHello: {str}");


            int num = GetSum(2,5);
            Console.WriteLine($"Got from GetSum: {num}");
        }


        //function that does not get parameters and does not return value
        static void PrintHello()
        {
            Console.WriteLine("Hello");
        }

        //function that gets parameters and does not return value
        static void PrintSum(int num1,int num2)
        {
            Console.WriteLine($"{num1}+{num2}={num1+num2}");
        }


        //function that does not get parameters and does return value
        static string GetHello()
        {
            return "Hello";
        }

        //function that gets parameters and does return value
        static int GetSum(int num1, int num2)
        {
            return num1 + num2;
        }

       
    }
}
