using System;

namespace _04_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 6;



            // תוכן caseאם יש בתוך ה
            //break חובה להוסיף בסופו 
            switch (num)
            {

                case 1: Console.WriteLine("I am 1"); break;
                case 2: Console.WriteLine("I am 2"); break;
                default:
                    Console.WriteLine("not 1 or 2");
                    break;
            }


            // תוכן caseאם אין בתוך ה
            //מותר לצרף כמה אופציות אחד אחרי בשני
            //ורק באופציה בה ניתן תוכן
            //break חובה להוסיף  
            switch (num)
            {

                case 1: Console.WriteLine("Sunday"); break;
                case 2: Console.WriteLine("Monday"); break;
                case 5:
                case 6:
                case 7: Console.WriteLine("Weekend"); break;
                default:
                    Console.WriteLine("not Sunday or Monday");
                    break;
            }
        }
    }
}
