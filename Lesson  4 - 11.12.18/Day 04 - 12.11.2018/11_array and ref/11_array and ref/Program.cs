using System;

namespace _11_array_and_ref
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };

            Console.WriteLine("-------------Step 1:--------------");
            PrintArr(array);

            ChangeElement(array);


            Console.WriteLine("-------------Step 2:--------------");
            PrintArr(array);



            ChangeArr1(array);


            Console.WriteLine("-------------Step 3:--------------");
            PrintArr(array);


            ChangeArr2(ref array);


            Console.WriteLine("-------------Step 4:--------------");
            PrintArr(array);
        }

        

        static void ChangeElement(int[] arr)
        {

            Console.WriteLine("-------------ChangeElement start--------------");
            PrintArr(arr);


            arr[1] = 9;


            Console.WriteLine("-------------ChangeElement end--------------");
            PrintArr(arr);
        }


        static void ChangeArr1(int[] arr)
        {


            Console.WriteLine("-------------ChangeArr1 start--------------");
            PrintArr(arr);

            arr = new int[] { 2, 2, 2 };


            Console.WriteLine("-------------ChangeArr1 end--------------");
            PrintArr(arr);

        }


        static void ChangeArr2(ref int[] arr)
        {


            Console.WriteLine("-------------ChangeArr2 start--------------");
            PrintArr(arr);

            arr = new int[] { 2, 2, 2 };


            Console.WriteLine("-------------ChangeArr2 end--------------");
            PrintArr(arr);

        }


        static void PrintArr(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ,");
            }
            Console.WriteLine();
        }

        
    }
}
