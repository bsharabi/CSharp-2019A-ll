
using Animal;
using System;


namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            // "Cat" is in "Animal" namespace
            // first way to use external namespace : add the namespace name in the top with "using"
            Cat a = new Cat();

            Console.WriteLine(a.Age);  //--> 12

            // second way to use external namespace : add the namespace name before the class name
            Collage.High_Collage.Student s1 = new Collage.High_Collage.Student();
            Collage.Low_Collage.Student s2 = new Collage.Low_Collage.Student();

            Console.WriteLine(s1.Grade);  //--> 100

            Console.WriteLine(s2.Name);   //--> Bob
        }
    }
}
