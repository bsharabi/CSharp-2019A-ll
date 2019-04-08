using System;


namespace Q1___result
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person("Gogo",new Date(1942,4,17),null,null);
            Person p2 = new Person("Gigi", new Date(1945,8, 21),null, null);
            Person p3 = new Person("Momo", new Date(1980,05,08),p1,p2);

            Console.WriteLine(p3.GetDescription());
        }
    }
}
