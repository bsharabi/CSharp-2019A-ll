using System;

namespace _02_static_class
{
    //static class can contain only static functions, static properties, and static constructor
    //We can not create an instance og a static class
    static class Calculator
    {

        private static int sumOfOperations;

        public static int SumOfOperations
        {
            get { return sumOfOperations; }
            set { sumOfOperations = value; }
        }


        static Calculator()
        {
            Console.WriteLine("static constructor is running");
        }

        public static int Calc(int num1, int num2, char operation)
        {
            SumOfOperations++;

            switch (operation)
            {
                case '+': return num1 + num2;
                case '-': return num1 - num2;
                case '*': return num1 * num2;
                case '/': return num1 / num2;
            }


            return 0;
        }

    }
}
