using System;

namespace _00_constructor
{
    class Person
    {

        //--------------properties--------------
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        //-----------constructor------------
        public Person()
        {
            Console.WriteLine("New person was born");
        }

        //-----------methods------------
        public string GetDescription()
        {
            return $"Age: {Age}, Name: {Name}";
        }

    }
}
