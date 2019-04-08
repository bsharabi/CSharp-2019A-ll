using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //----------numeric (מספרים שלמים)---------

            // 1 byte - from 0 to 255
            byte b = 12;

            // 4 byte
            int i = 12;

            // 8 byte
            long l = 12;



            //----------numeric (מספרים עשרוניים)--------
            double d = 12.4;
            float f = 2.44f;
            decimal dm = 3.55m;



            //----------------המרה מרומזת------------
            //המרה מרומזת תתבצע כאשר נשים משתנה מטיפוס אחד למשתנה מטיפוס אחר
            //כל עוד אין חשש שנאבד במהלך ההמרה שום מידע 

            //byte to int
            i = b;

            //byte to long
            l = b;

            //byte to double
            d = b;


            //byte to float
            f = b;


            //byte to decimal
            dm = b;

            //int to long
            l = i;


            //int to double
            d = i;


            //int to float
            f = i;


            //int to decimal
            dm = i;


            //long to double
            d = l;


            //long to float
            f = l;


            //long to decimal
            dm = l;


            //----------------המרה מפורשת------------
            //המרה מפורשת תתבצע כאשר נשים משתנה מטיפוס אחד למשתנה מטיפוס אחר
            //ויש חשש שנאבד במהלך ההמרה שום מידע 


            //int to byte
            b = (byte)i;

            //long to byte
            b = (byte)l;

            //long to int
            i = (int)l;

            //double to byte
            b = (byte)d;


            //double to int
            i = (int)d;


            //double to long
            l=(long)d;

            //double to float
            f = (float)d;

            //double to decimal
            dm = (decimal)d;
        }
    }
}
