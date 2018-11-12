using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Result_class_task
{
    class Person
    {
        public string Name;
        public double age;
        public string Getdes()
        {
            return Console.WriteLine($"The name is {Name} , the age is {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Person1 = new Person();
            Person1.Name = "Bob";
            Person1.age = 17.5;
            Console.WriteLine(Person1.Getdes);
            Person Person2 = new Person();
            Person2.Name = "Alice";
            Person2.age = 18.5;
            Console.WriteLine(Person2.Getdes);
        }
    }
}
