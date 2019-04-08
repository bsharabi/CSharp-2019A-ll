using System;


namespace test
{

    class Program
    {
        static void Main(string[] args)
        {

            Student[] studentsArray = {
                new Student("Bob", "Math",BobAction),
                new Student("Alice", "Physics",AliceAction)
        };


            foreach (Student student in studentsArray)
            {
                student.SubjectReactionFunc(student.Subject);
            }
        }



        public static void BobAction(string s)
        {
            Console.WriteLine($"my best subject is: {s}");
        }

        public static void AliceAction(string x)
        {
            Console.WriteLine($"I love {x}");
        }

    }
}
