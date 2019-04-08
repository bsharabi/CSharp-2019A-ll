using System;

namespace _01_jugged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Parent 1 : Yanai, Igal
             ------
             Parent 2 : Bob, Alice , Tom
             */

            string[][] childrenMatrix = new string[2][];

            childrenMatrix[0] = new string[2] { "Yanai", "Igal" };
            childrenMatrix[1] = new string[3] { "Bob", "Alice", "Tom" };


            foreach (string[] matrixItem in childrenMatrix)
            {
                Console.WriteLine("This parent has the following children");
                foreach (string arrItem in matrixItem)
                {
                    Console.WriteLine(arrItem);
                }

                Console.WriteLine();

            }
        }
    }
}
