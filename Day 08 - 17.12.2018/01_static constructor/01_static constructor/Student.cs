using System;

namespace _01_static_constructor
{
    class Student
    {

        //-----------------------normal constructor----------------------
        // constructor - is running each time an instance of the class in created
        public Student(string name)
        {
            Console.WriteLine($"{name} is created");
        }



        //-----------------------static constructor----------------------
        // static constructor - is running only the first time that the class in used
        
        //access modifiers are not allowed on static constructors	
        //a static constructor must be parameterless
        static Student()
        {
            Console.WriteLine("I am a static constructor");
        }
    }
}
