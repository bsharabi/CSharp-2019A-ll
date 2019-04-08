using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result
{
    delegate void SubjectReaction1(string str , string str1);

    class Student
    {
        public string StudenName { get; set; }
        public string Subject { get; set; }
        public SubjectReaction1 SubjectReaction { get; set; }

        public Student(string name,string subject, SubjectReaction1 subjectReaction )
        {

            StudenName = name;
            Subject = subject;
            SubjectReaction = subjectReaction;
        }
    }


    class Program
    {
        static void print1(string x, string s)
        {

            Console.WriteLine($"My {s} is : {x}");



        }
        static void Main(string[] args)
        {

            Student student = new Student("barak", "Math",print1);
            student.SubjectReaction(student.StudenName, "StudenName");

            Student[] s1 = {
                new Student ("bob", "Math", print1),
                new Student ("alice", "Pysical", print1),
            };
            foreach(Student stud in s1)
                stud.SubjectReaction(stud.StudenName, "StudenName");


        }
    }
}
