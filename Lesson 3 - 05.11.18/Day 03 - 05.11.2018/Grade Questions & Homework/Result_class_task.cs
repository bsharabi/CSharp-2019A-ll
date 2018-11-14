using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
   class Program
   {
       static void Main(string[] args)
       {
           int num;
           do
           {
               Console.WriteLine("Please enter a number between 3 and 9");
               num = Convert.ToInt32(Console.ReadLine());
           } while (num < 3 || num > 9);
           int[][] matrix = new int[num][];

           int row,col;
           for(row=0;row<num;row++)
           {
               matrix[row] = new int[row + 1]; 
               for (col = 0; col <= row; col++)
               {
                   matrix[row][col] = row + 1;
               }
           }
           //Print Method -1 
           foreach (int[] Xmatrix in matrix)
           {
               foreach (int Yarr in Xmatrix)
               {
                   Console.Write(Yarr);
               }
               Console.WriteLine();
           }
           //Print Method -2 
           Console.WriteLine();
           for (row = 0; row < num; row++)
           {
               for (col = 0; col <= row; col++)
               {
                   Console.Write(matrix[row][col]);
               }
               Console.WriteLine();
           }

       }
   }
}
