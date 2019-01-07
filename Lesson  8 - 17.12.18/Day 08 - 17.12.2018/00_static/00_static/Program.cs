using System;


namespace _00_static
{
    class Program
    {
        static void Main(string[] args)
        {


            Student s1 = new Student(100);
            Console.WriteLine(Student.GetTotalGrade());

            Student s2 = new Student(90);
            Console.WriteLine(Student.GetTotalGrade());

            Student s3 = new Student(80);
            Console.WriteLine(Student.GetTotalGrade());

            s1.Grade = 95;
            Console.WriteLine(Student.GetTotalGrade());


        }
    }
}
