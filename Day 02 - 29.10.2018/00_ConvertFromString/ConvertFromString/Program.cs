using System;

namespace ConvertFromString
{
    class Program
    {
        static void Main(string[] args)
        {

            //-------------------- Convert from string to number -----------------
            int num1 = Convert.ToInt32("3");

            double num2 = Convert.ToDouble("7.8");


            //-------------------- Convert from number to string -----------------
            string strNum1 = num1.ToString();

            string strNum2 = num2.ToString();
        }
    }
}
