using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            byte lenarr, num2;
            Random r = new Random();//מספר רנדומלי לתוך משתנה R
            int x = r.Next(5,9);
            int y = r.Next(2, 5);
            lenarr = (byte)x;
            int[] arr = new int[lenarr];
            num2 = (byte)y;
            for (int i = 0; i < lenarr; i++)
            {
                arr[i] = i * num2;
            }
            for (int i = 0; i < lenarr; i++)
            {
                Console.Write(arr[i]);
                if(i<lenarr-1)
                Console.Write(" , ");
            }
            Console.WriteLine();
            Console.WriteLine($"Num of mul {num2}");
            Console.WriteLine($"Num of elements {lenarr}");
            Console.Read();
            Console.Clear();
            Main(args);




        }
    }
}
