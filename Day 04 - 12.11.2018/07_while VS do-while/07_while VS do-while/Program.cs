using System;

namespace _07_while_VS_do_while
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 4;

            Console.WriteLine("-------------while------------------");
            int whileCounter = 4;
            while (whileCounter < limit)
            {
                Console.WriteLine(whileCounter);
                whileCounter++;
            }



            Console.WriteLine("------------do-while------------------");
            int doCounter = 4;
            do
            {
                Console.WriteLine(doCounter);
                doCounter++;
            } while (doCounter < limit);


           
        }
    }
}
