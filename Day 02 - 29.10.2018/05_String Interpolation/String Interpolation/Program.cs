using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Interpolation
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "hello";

            Console.WriteLine(" 1 + 1 ={1+1} ");   //-->  1 + 1 ={1+1}
            Console.WriteLine(" msg is : {str} "); //--> msg is : {str}

            Console.WriteLine($" 1 + 1 ={1 + 1} "); //--> 1 + 1 = 2
            Console.WriteLine($" msg is : {str} "); //--> msg is : hello
        }
    }
}
