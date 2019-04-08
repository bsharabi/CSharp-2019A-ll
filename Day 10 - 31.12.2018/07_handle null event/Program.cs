using System;

namespace _06_Student_action
{
    //step 1 - declare a delegate
    delegate void ActionHandler(string subject);


    class Student
    {
        //step 2 - create an event with the delegate from step 1
        public event ActionHandler MorningActions;

        public void WakeUp(string str)
        {
            //step 4 - call to the delegate - via the class



            //if we invoke MorningActions before we addesd functions to it
            //we will get Unhandled Exception: System.NullReferenceException
            //So - in this way we are checking that MorningActions is not null
            MorningActions?.Invoke(str);


            //if we want to check and execute other action if MorningActions is null
            //we can not use: MorningActions?.Invoke(str);
            //and we need to use the long way
            if (MorningActions != null)
            {
                MorningActions(str);

            }
            else
            {
                System.Console.WriteLine("Sorry - we cant do this event");

            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();


            student.WakeUp("I called the class - first time");


            //step 3 - subscribe a function to the event
            student.MorningActions += (s) => { Console.WriteLine($"students says: {s}"); };

            student.WakeUp("I called the class - second time");

        }
    }
}

/*
OUTPUT:
_______________________________________
Sorry - we cant do this event
students says: I called the class - second time
students says: I called the class - second time
*/

