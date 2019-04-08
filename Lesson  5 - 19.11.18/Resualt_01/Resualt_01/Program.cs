using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resualt_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("How many cookies you'd like to produce");//output to screen
            int num = Convert.ToInt32(Console.ReadLine());
            Coockie[] coockies = new Coockie[num];//Create a coockie_class in stack
            Create(coockies);//Create a coockie_class in heep and 
            Print_Coockie(coockies);
            coockies[0] = coockies[1];
            Print_Coockie(coockies);
            coockies[0].Eggs = 20;
            Print_Coockie(coockies);
            coockies[1].Eggs = 80;
            Print_Coockie(coockies);
            Console.ReadLine();
            Console.Clear();*/
            Car car1 = new Car();
            Print_Car(car1);



        }
        static void Create(Coockie[] coockies)
        {
            for (int i = 0; i < coockies.Length; i++)
            {
                coockies[i] = new Coockie();
                Console.WriteLine($"cookie number {i+1}");
                Console.WriteLine("Some eggs have a cookie");
                coockies[i].Eggs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Does the cookie contain gluten (yes or no)?");
                string check = (Console.ReadLine());
                bool value = (check == "yes") ? (value = true) : (value = false);
                coockies[i].Gluten = value;
                Console.WriteLine("How much sugar is in the cookie:");
                coockies[i].Sugar = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("How much flour is in the cookie:");
                coockies[i].Flour = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            }
        }
        static void Print_Coockie(Coockie[] coockies)
        {
            for (int i = 0; i < coockies.Length; i++)
            {
                Console.WriteLine($"The cookie {i+1} has :");
                Console.WriteLine($"You have a {coockies[i].Eggs} Eggs");
                Console.WriteLine($"Does the cookie contain gluten :  {coockies[i].Gluten}");
                Console.WriteLine($"You have a {coockies[i].Sugar} kg Sugar");
                Console.WriteLine($"You have a {coockies[i].Flour } kg Flour");
                Console.WriteLine("------------------------------------------------");
            }
        }
        static void Print_Car(Car car1)
        {
            Console.WriteLine($"{car1.Speed_hi}");
            Console.WriteLine($"{car1.Speed_low}");
            Console.WriteLine($"{car1.Stop}" );
            Console.WriteLine("------------------------------------------------");

        }
    }
}
