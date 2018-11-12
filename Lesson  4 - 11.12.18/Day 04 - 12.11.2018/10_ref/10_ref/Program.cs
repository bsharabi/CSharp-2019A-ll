using System;

namespace _10_ref
{
    class Program
    {

        static void ChangeNum(ref int n1, ref int n2)
        {
            Console.WriteLine($"n1: {n1}, n2: {n2}");
            int temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine($"n1: {n1}, n2: {n2}");

        }
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 8;

            Console.WriteLine($"BEFORE ------------ num1: {num1}, num2: {num2}");


            //שליחה של הכתובת של המשתנה - לא של תוכן המשתנה
            ChangeNum(ref num1, ref num2);

            Console.WriteLine($"AFTER ------------ num1: {num1}, num2: {num2}");
        }
    }
}
