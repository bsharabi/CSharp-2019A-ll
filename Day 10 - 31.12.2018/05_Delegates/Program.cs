/*
כללים חשובים:
1. += אפשר לבצע השמה של כמה פונקציות למשתנה אחד באמצעות האופרטור  
2. -= אפשר להסיר פונקציה ספציפית מהמשתנה ע"י האופרטור  
3. כאשר נפעיל פונקציה שרשומות עבורה כמה פונקציות- הפונקציות יופעלו אחת אחרי השניה לפי הסדר שהתווספו למשתנה
4. הערך המוחזר שיתקבל בסוף ביצוע כל הפונקציות הרשומות למשתנה - יהיה הערך המוחזר מהפונקציה האחרונה שהתווספה למשתנה  
 
 */


using System;


// in a namespace we can write: class / interface / enum / delegate
namespace _02_Delegates
{
    //a function that gets two int parameters and returns a string
    delegate string ExecAction(int num1, int num2);

    class Program
    {

        static string DivNum(int n1, int n2)
        {
            Console.WriteLine($"div of {n1} and {n2} is {n1 / n2}");
            return $"div of {n1} and {n2} is {n1 / n2}";
        }

        static string MulNum(int n1, int n2)
        {
            Console.WriteLine($"mul of {n1} and {n2} is {n1 * n2}");
            return $"mul of {n1} and {n2} is {n1 * n2}";
        }

        static string SubNum(int n1, int n2)
        {
            Console.WriteLine($"sub of {n1} and {n2} is {n1 - n2}");
            return $"sub of {n1} and {n2} is {n1 - n2}";
        }

        static void Main(string[] args)
        {
            ExecAction action1;
            
            action1 = DivNum;
            action1 += MulNum;
            action1 += MulNum;
            action1 += SubNum;
            action1 -= DivNum;

            Console.WriteLine("--------------------------action1-----------------------");

            string result = action1(4, 2);

            Console.WriteLine("--------------------------Now we print the returned value (action1)-----------------------");
            Console.WriteLine(result);


            ExecAction action2;

            action2 = DivNum;
            action2 += MulNum;
            action2 += MulNum;
            action2 += SubNum;
            action2 = MulNum;  //--> overriding

            Console.WriteLine("--------------------------action2-----------------------");
            result = action2(4, 2);

            Console.WriteLine("--------------------------Now we print the returned value (action2)-----------------------");
            Console.WriteLine(result);

        }
    }
}


/*
OUTPUT:
________________________
 
--------------------------action1-----------------------
mul of 4 and 2 is 8
mul of 4 and 2 is 8
sub of 4 and 2 is 2
--------------------------Now we print the returned value (action1)-----------------------
sub of 4 and 2 is 2

--------------------------action2-----------------------
mul of 4 and 2 is 8
--------------------------Now we print the returned value (action2)-----------------------
mul of 4 and 2 is 8
     
*/
