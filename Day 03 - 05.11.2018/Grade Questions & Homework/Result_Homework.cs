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
            int num1;
            do
            {
                Console.WriteLine("Please enter an odd matrix size between 3 and 9");
                num1 = Convert.ToInt32(Console.ReadLine());
            } while (num1 <3 || num1 %2==0 || num1>9);
            string[][] matrixStr = new string[num1][];
            for(int row=0;row<num1;row++)
            {
                matrixStr[row] = new string[num1];
                for (int col = 0; col < num1; col++)
                {
                    if (row == col&& row+col!=num1-1)
                        matrixStr[row][col] = "Main";
                    else if (row + col == num1 - 1 && row!=col)
                            matrixStr[row][col] = "Sub";
                    else  if (row + col == num1 - 1 && row==col)
                            matrixStr[row][col] = "center";
                    else if (row > col && row + col != num1 - 1)
                        matrixStr[row][col] = "Down";
                    else  if (row < col && row + col != num1 - 1)
                        matrixStr[row][col] = "Up";
                }
            }
            foreach (string[] Xmatrix in matrixStr)
            {
                foreach (string Yarr in Xmatrix)
                {
                    Console.Write(Yarr + "    ");
                }
                Console.WriteLine('\n');
            }

        }
    }
}
