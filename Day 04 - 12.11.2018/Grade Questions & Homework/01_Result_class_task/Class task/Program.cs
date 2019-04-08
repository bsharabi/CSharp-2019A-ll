using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_task
{
    class Program
    {
        static void Exchanging_numbers(int num , int num2)
        {
            Console.WriteLine("--------------------Function---------------------");
            Console.WriteLine($"In function Before ----- Num = {num},Num2 = {num2}");
            Console.WriteLine("-------------------------------------------------\n");
            num = num + num2;
            num2 = num - num2;
            num = num-num2;
            Console.WriteLine("--------------------Function---------------------");
            Console.WriteLine($"In function After  ----- Num = {num},Num2 = {num2}");
            Console.WriteLine("-------------------------------------------------\n");
        }
        static void Rexchanging_numbers(ref int  num, ref int num2)
        {
            Console.WriteLine("--------------------Function---------------------");
            Console.WriteLine($"In function Before ----- Num = {num},Num2 = {num2}");
            Console.WriteLine("-------------------------------------------------\n");
            num = num + num2;
            num2 = num - num2;
            num = num - num2;
            Console.WriteLine("--------------------Function---------------------");
            Console.WriteLine($"In function After  ----- Num = {num},Num2 = {num2}");
            Console.WriteLine("-------------------------------------------------\n");
        }

        static void Main(string[] args)
        {
            int num,num2;
            Console.WriteLine("Enter your num you want Exchanging");
            num =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your num you want Exchanging");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------Main------------------------");
            Console.WriteLine($"Before ----- Num = {num},Num2 = {num2}");
            Console.WriteLine("------------------------------------------------\n");
            Exchanging_numbers(num,num2);
            Console.WriteLine("--------------------Main------------------------");
            Console.WriteLine($"After  ----- Num = {num},Num2 = {num2}");
            Console.WriteLine("------------------------------------------------\n");


            Console.WriteLine("-----------------With_Ref-----------------------\n\n");
            Console.WriteLine("--------------------Main------------------------");
            Console.WriteLine($"Before ----- Num = {num},Num2 = {num2}");
            Console.WriteLine("------------------------------------------------\n");
            Rexchanging_numbers(ref num, ref num2);
            Console.WriteLine("--------------------Main------------------------");
            Console.WriteLine($"After  ----- Num = {num},Num2 = {num2}");
            Console.WriteLine("------------------------------------------------\n");
        }
    }
}
