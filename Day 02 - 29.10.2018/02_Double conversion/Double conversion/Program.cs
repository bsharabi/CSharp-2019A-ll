using System;

namespace Double_conversion
{
    class Program
    {
        static void Main(string[] args)
        {

            //double כל פעם שנרשום מספר עשרוני הוא ייחשב כברירת מחדל מטיפוס 
            double d = 7.3;



            //-------------from double to float-המרה מפורשת-----------------
            float f1 =(float) 7.3;
            float f2 = 7.3f;


            //-------------from double to decimal-המרה מפורשת-----------------
            decimal d1 = (decimal)7.3;
            decimal d2 = 7.3m;
        }
    }
}
