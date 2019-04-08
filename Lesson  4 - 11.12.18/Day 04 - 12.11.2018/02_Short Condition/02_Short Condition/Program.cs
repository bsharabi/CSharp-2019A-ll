using System;

namespace _02_Short_Condition
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;


            string res1;

            if (flag)
            {
                res1 = "flag is true";
            }
            else
            {
                res1 = "flag is false";
            }
            Console.WriteLine($"res1: {res1}");

            string res2;

            res2=(flag)? "flag is true": "flag is false";

            Console.WriteLine($"res2: {res2}");
        }
    }
}
