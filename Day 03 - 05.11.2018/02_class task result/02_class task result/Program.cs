using System;

namespace _02_class_task_result
{
    class Program
    {
        static void Main(string[] args)
        {

            int numOfRows;


            //הלולאה הזו תרוץ לפחות פעם אחת
            //אם נקלט מספר שקטן משלוש או גדול מתשע היא תרוץ שוב
            do
            {
                Console.WriteLine("Please enter a number (between 3-9): ");
                numOfRows = Convert.ToInt32(Console.ReadLine());
            } while (numOfRows < 3 || numOfRows > 9);


            //יצירת מטריצה מאותחלת עם מספר שורות לפי הקלט מהלקוח
            //null בשלב זה כל תא במטריצה מכיל 
            int[][] matrix = new int[numOfRows][];


            //לולאה שרצה על כל שורה במטריצה
            for (int row = 0; row < matrix.Length; row++)
            {
                //null בשלב זה כל תא במטריצה מכיל 
                //נאתחל כעת את התא במצביע למערך בעל אורך הגדול ב1 האינדקס התא
                matrix[row] = new int[row + 1];


                // נאתחל כל תא בשורה של המטריצה עם מספר - המספר יהיה אינדקס השורה + 1
                for (int col = 0; col < matrix[row].Length; matrix[row][col++]= row+1);
            }


            foreach (int[] matrixItem in matrix)
            {
                foreach (int arrItem in matrixItem)
                {
                    Console.Write(arrItem);
                }
                Console.WriteLine();
            }
        }
    }
}
