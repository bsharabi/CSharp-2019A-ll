using System;

namespace _02_static_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"SumOfOperations: {Calculator.SumOfOperations}");

            int num1 = 9, num2 = 3;

            Console.WriteLine($"{num1} + {num2} = {Calculator.Calc(num1,num2,'+')}");
            Console.WriteLine($"SumOfOperations: {Calculator.SumOfOperations}");


            Console.WriteLine($"{num1} - {num2} = {Calculator.Calc(num1, num2, '-')}");
            Console.WriteLine($"SumOfOperations: {Calculator.SumOfOperations}");


            Console.WriteLine($"{num1} / {num2} = {Calculator.Calc(num1, num2, '/')}");
            Console.WriteLine($"SumOfOperations: {Calculator.SumOfOperations}");

            Console.WriteLine($"{num1} * {num2} = {Calculator.Calc(num1, num2, '*')}");
            Console.WriteLine($"SumOfOperations: {Calculator.SumOfOperations}");
        }
    }
}
