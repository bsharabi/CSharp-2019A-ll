# non - readonly
```csharp
using System;
namespace app
{

    class Coffee
    {
        public static int SugarSpoons = 1;
        public int CoffeeSpoons = 2;

        public Coffee(int coffeeSpoons)
        {
            CoffeeSpoons = coffeeSpoons;
        }

        public string GetInfo()
        {
            return $"CoffeeSpoons:{CoffeeSpoons}, SugarSpoons:{SugarSpoons} ";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Coffee c1 = new Coffee(3);

            Console.WriteLine(c1.GetInfo());  //--> CoffeeSpoons:3, SugarSpoons:1

            Coffee.SugarSpoons = 4;

            Console.WriteLine(c1.GetInfo()); //--> CoffeeSpoons: 3, SugarSpoons: 4


            c1.CoffeeSpoons = 5;

            Console.WriteLine(c1.GetInfo()); //--> CoffeeSpoons: 5, SugarSpoons: 4
        }
    }
}

```

# readonly
```csharp
using System;
namespace app
{

    class Coffee
    {

        //A static readonly field cannot be assigned to(except in a static constructor or a variable initializer)	
        public static readonly int SugarSpoons = 1;


        //A readonly field cannot be assigned to(except in a constructor or a variable initializer)          
        public readonly int CoffeeSpoons = 2;


        public Coffee(int coffeeSpoons)
        {
            CoffeeSpoons = coffeeSpoons;
        }

        public string GetInfo()
        {
            return $"CoffeeSpoons:{CoffeeSpoons}, SugarSpoons:{SugarSpoons} ";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Coffee c1 = new Coffee(3);

            Console.WriteLine(c1.GetInfo());  //--> CoffeeSpoons:3, SugarSpoons:1

        }
    }
}

```
