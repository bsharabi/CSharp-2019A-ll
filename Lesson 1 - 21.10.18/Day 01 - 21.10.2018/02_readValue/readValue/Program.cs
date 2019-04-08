using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readValue
{
    class Program
    {
        static void Main(string[] args)
        {

            string str;

            Console.WriteLine("Say somthing:");

            // `ReadLine()` - a function that returns the input from the keyboard as a string
            // this takes all the input until the user presses `enter`
            str = Console.ReadLine();
            
             
            Console.WriteLine($"you said: {str}");

            Console.WriteLine($"2+5= {2+5}");
        }
    }
}
