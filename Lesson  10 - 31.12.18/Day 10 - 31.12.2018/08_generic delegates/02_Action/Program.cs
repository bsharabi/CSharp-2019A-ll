
//-------------------Action-------------------
//יש להעביר פרמטרים מופרדים בפסיק -  16- 1 פרמטרים
//the type of the parameter is in the <>
//אבל אי אפשר בשום מצב להחזיר ערך

using System;

namespace _02_Action
{

    delegate void MyAction(int n1, int n2);

    class Program
    {
        static void PrintNum(int num1,int num2)
        {
            Console.WriteLine($"num1:{num1}, num2:{num2}");
        }

        static void Main(string[] args)
        {


            MyAction a0 = PrintNum;

            //a delegate that can ref any function that gets int and returns void
            Action<int,int> a1 = PrintNum;


            a0(1,2);
            a1(1,2);


        }
    }
}


/*
 
OUTPUT:
_______________
num1:1, num2:2
num1:1, num2:2*/
