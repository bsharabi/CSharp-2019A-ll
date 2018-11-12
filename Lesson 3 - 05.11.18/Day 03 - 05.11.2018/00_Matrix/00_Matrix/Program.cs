using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------- way 1 to craete a mtrix ---------
            int[] arr1 = { 1, 1, 1 };
            int[][] matrix1 = {new int[]{ 1, 1, 1 }, new int[] { 1, 1, 1 }};


            //----------- way 2 to craete a mtrix ---------
            int[] arr2 = new int[3]{ 1, 1, 1 };
            int[][] matrix2 = new int[2][] { new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 } };


            //----------- way 3 to craete a mtrix ---------

            int[] arr3 = new int[3];
            arr3[0] = 1;
            arr3[1] = 2;
            arr3[2] = 3;


            int[][] matrix3 = new int[2][];
            matrix3[0] = new int[3] { 11, 12, 13 };
            matrix3[1] = new int[3] { 21, 22, 23 };

            Console.WriteLine("--------------arr3 foreach ----------------------");
            foreach(int arrItem in arr3)
            {
                Console.WriteLine($"arr3 foreach : {arrItem}");
            }

            Console.WriteLine("--------------arr3 for ----------------------");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine($"arr3 for : {arr3[i]}");
            }

            Console.WriteLine("--------------matrix3 foreach ----------------------");
            foreach (int[] matrixItem in matrix3)
            {
                foreach (int arrItem in matrixItem)
                {
                    Console.WriteLine($"matrix3 foreach : {arrItem}");
                }
            }

            Console.WriteLine("--------------matrix3 for ----------------------");
            for (int row = 0; row < matrix3.Length; row++)
            {
                for (int col = 0; col < matrix3[row].Length; col++)
                {
                    Console.WriteLine($"matrix3 for : {matrix3[row][col]}");
                }
            }
        }
    }
}
