//-------------------Predicate (builtin in .net)-------------------
//Predicate - gets one parameter
//the type of the parameter is in the <>
//returns a boolean val

using System;

namespace _01_Peredicate
{
    //MyPredicate declares a type of a delegare that cam point to any
    //function that takes an int as a paerameter and returns bool
    delegate bool MyPredicate(int num);

    class Program
    {
        static bool isPos(int num)
        {
            return num > 0;
        }

        static void Main(string[] args)
        {
            MyPredicate pr0 = isPos;

            //pr1 takes an int as a paerameter and returns bool
            Predicate<int> pr1=isPos;

            Console.WriteLine(pr0(7));
            Console.WriteLine(pr1(7));
        }
    }
}


/* 
     OUTPUT
     ________________________
     True
     True
*/
