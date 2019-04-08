using System;


namespace test
{

    
    enum Color
    {
        RED,
        GREEN,
        BLUE
    }

    class Program
    {
        static void Main(string[] args)
        {

            Color C1 = Color.RED;
            Console.WriteLine(C1);  //--> RED
            

            Color C2 = (Color)(1);
            Console.WriteLine(C2); //--> GREEN
        }
    }
}
