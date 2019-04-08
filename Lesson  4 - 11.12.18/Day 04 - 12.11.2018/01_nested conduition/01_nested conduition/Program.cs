using System;

namespace _01_nested_conduition
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = 7;
            bool IsWinePerson = false;

            if(age<0 || age > 120)
            {
                // "age" < 0   OR  "age" > 120
                Console.WriteLine("Invalid age!!!!");
            }
            else if (age < 25)
            {
                // "age" >= 0   AND   "age" < 25
                Console.WriteLine("You can only drink soft drink");
            }
            else
            {
                // "age" >= 25   AND   "age" <= 120

                //------------nested condition-(תנאי בתוך תנאי)------------
                if (IsWinePerson)
                {
                    Console.WriteLine("You can drink wine!!!");
                }
                else
                {
                    Console.WriteLine("You can drink beer");
                }
            }
        }
    }
}
