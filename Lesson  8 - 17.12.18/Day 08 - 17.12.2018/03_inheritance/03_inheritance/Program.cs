using System;


namespace _03_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza p = new Pizza();
            p.IsVeg = true;
            p.NumOfSlices = 8;
            p.Price = 90;


            Console.WriteLine($"our pizza has {p.NumOfSlices} slices and costs {p.Price}");

            Console.WriteLine("the pizza is: " + ((p.IsVeg) ? " veg" : "non-veg"));
        }
    }
}
