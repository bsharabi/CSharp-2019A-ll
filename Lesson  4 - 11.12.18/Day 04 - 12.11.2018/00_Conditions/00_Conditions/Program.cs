using System;
namespace _00_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int num = 7;


            //----------------------אופציה 1 לשימוש בתנאים - עם משתנה בוליאני----------------------------

            //true כאשר נשתמש בטיפוס בוליאני אין צורך להשוותו לערך 
            //true כי בצורה דיפולטיבית המשתנה נבדק האם הוא מכיל בתוכו 
            if (flag)
            {
                //if "flag" contains "true"
                Console.WriteLine("flag is true");

            }
            else
            {
                //if "flag" contains "false"
                Console.WriteLine("flag is false");
            }

            // (!flag) is equal to (flag==false)
            if (!flag)
            {
                //if "flag" contains "false"
                Console.WriteLine("flag is false");
            }
            else
            {
                //if "flag" contains "true"
                Console.WriteLine("flag is true");               
            }



            //----------------------אופציה 2 לשימוש בתנאים - עם ביטוי שמחזיר ערך בוליאני----------------------------
            if (num<8)
            {
                //if num<8
                Console.WriteLine($"num {num} is lt 8");

            }
            else
            {
                //if num is not smaller than 8
                Console.WriteLine($"num {num} is gt 8");
            }


            //--------------------- (true / false) אופציה 3 לשימוש בתנאים - עם ערך בוליאני ישיר----------------------------
            if (true)
            {
                Console.WriteLine("I am true");

            }
            else
            {
                Console.WriteLine("I am false");
            }
        }
    }
}
