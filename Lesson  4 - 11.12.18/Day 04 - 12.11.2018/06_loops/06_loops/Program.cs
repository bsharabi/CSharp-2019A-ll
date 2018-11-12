using System;

namespace _06_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 4;

            Console.WriteLine("-------------while------------------");
            int whileCounter = 0;
            while (whileCounter < limit)
            {
                Console.WriteLine(whileCounter);
                whileCounter++;
            }



            Console.WriteLine("------------do-while------------------");
            int doCounter = 0;
            do
            {
                Console.WriteLine(doCounter);
                doCounter++;
            } while (doCounter < limit);


            Console.WriteLine("-------------for------------------");
            for (int forCounter = 0; forCounter < limit; forCounter++)
            {
                Console.WriteLine(forCounter);
            } 
        }
    }
}
