using System;


// in a namespace we can write: class / interface / enum / delegate
namespace _02_Delegates
{
    //a function that gets two int parameters and returns a string
    delegate string ExecAction(int num1, int num2);


    class Program
    {

        static string DivNum(int n1, int n2)
        {
            Console.WriteLine($"div of {n1} and {n2} is {n1 / n2}");
            return $"div of {n1} and {n2} is {n1 / n2}";
        }

        static void Main(string[] args)
        {
            ExecAction action;

            //!!!!!!!!!!!!!!!!!!!! OVERRIDING THE PREV VAL OF THE DELEGATE!!!!!!!!!!!!!!!!!!!!!!

            action = (int n1, int n2) => {
                Console.WriteLine($"mul of {n1} and {n2} is {n1 * n2}");
                return $"mul of {n1} and {n2} is {n1 * n2}";
            };

            //when we have in the function's body only one command' we can remove '{return }'
            action = (int n1, int n2) => {
                Console.WriteLine($"sum of {n1} and {n2} is {n1 + n2}");
                return $"sum of {n1} and {n2} is {n1 + n2}";
            };

            //we dont need to write the parameters type - becuse we get it from the delegate decleration
            action = (n1, n2) => {
                Console.WriteLine($"mod of {n1} and {n2} is {n1 % n2}");
                return $"mod of {n1} and {n2} is {n1 % n2}";

            };

            action = DivNum;


            string result = action(4, 2);

            Console.WriteLine("--------------------------Now we print the returned value-----------------------");
            Console.WriteLine(result);

        }
    }
}




/*
OUTPUT:
________________________
 
div of 4 and 2 is 2
--------------------------Now we print the returned value-----------------------
div of 4 and 2 is 2
     
*/
