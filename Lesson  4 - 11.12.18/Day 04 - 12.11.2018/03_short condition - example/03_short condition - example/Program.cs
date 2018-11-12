using System;

namespace _03_short_condition___example
{
    class Program
    {
        static void Main(string[] args)
        {

            //if (num > 9) so res is  ( num * 2 )
            //if (num <= 9) so res is  ( num - 4 )

            int num = 5;
            int res = (num > 9) ? (num * 2) : (num - 4);

            Console.WriteLine($"num is: {num}, res is: {res}");
        }
    }
}
