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
            return $"div of {n1} and {n2} is {n1 / n2}";
        }

        static void Main(string[] args)
        {
            ExecAction[] actionArray = new ExecAction[4];

            actionArray[0] = (int n1, int n2) => { return $"mul of {n1} and {n2} is {n1*n2}"; };

            //when we have in the function's body only one command' we can remove '{return }'
            actionArray[1] = (int n1, int n2) => $"sum of {n1} and {n2} is {n1 + n2}";

            //we dont need to write the parameters type - becuse we get it from the delegate decleration
            actionArray[2] = (n1, n2) => $"mod of {n1} and {n2} is {n1 % n2}";

            actionArray[3] = DivNum;


            foreach (ExecAction item in actionArray)
            {
               string result= item(4, 2);
                Console.WriteLine(result);
            }

        }
    }
}


/*
OUTPUT:
________________________
 
mul of 4 and 2 is 8
sum of 4 and 2 is 6
mod of 4 and 2 is 0
div of 4 and 2 is 2     
     
*/
