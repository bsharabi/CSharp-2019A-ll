using System;
namespace Class_Task_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num of elements:");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num to mul:");

            int num2 = Convert.ToInt32(Console.ReadLine());


            int[] arr = new int[num1];

            Console.WriteLine($"num of elements: {num1}, num of mul: {num2}");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * num2;
                Console.Write(arr[i] + " , "); 
            }

            
        }
    }
}
