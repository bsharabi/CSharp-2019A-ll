using System;

namespace _01_constructor_with_parameters
{
    class Program
    {
        static void Main(string[] args)
        {

            //פניה לבנאי שמקבל פרמטרים
            Book book1 = new Book(400, "c#");
            book1.PrintInfo();

            //פניה לבנאי הריק
            Book book2 = new Book();
            book2.PrintInfo();
        }
    }
}
