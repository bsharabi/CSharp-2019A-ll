using System;

namespace _05_switch_case___for_grades
{
    class Program
    {
        static void Main(string[] args)
        {
            // 90 - 100 --> "Perfect"
            // 80 - 90 --> "Very good"
            // 60 - 80 --> "Good"
            // 0 - 60 --> "Try to improve"


            int[] grades = new int[] { 100, 90, 83, 64, 53, 20 };

            foreach (int grade in grades)
            {

                Console.WriteLine($"----------grade : {grade}-------------------");
                switch (grade / 10)
                {
                    case 10:
                    case 9: Console.WriteLine("Perfect"); break;
                    case 8: Console.WriteLine("Very good"); break;
                    case 7:
                    case 6: Console.WriteLine("Good"); break;

                    default:
                        Console.WriteLine("Try to improve");
                        break;
                }

            }
           
        }
    }
}
