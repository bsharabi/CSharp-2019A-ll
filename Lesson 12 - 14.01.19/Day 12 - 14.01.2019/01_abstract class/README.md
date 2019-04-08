# abstract class
```csharp
using System;

namespace app
{
    //Cannot create an instance of the abstract class
    //We can create a variable of the abstract class type - that can point to non-abstarct sub-class instance
    abstract class Food
    {
        public decimal Price { get; set; } = 20;
    }


    class Pizza : Food
    {
        public int NumOfToppings { get; set; } = 2;
    }

    class Chips : Food
    {
        public bool IsExtraLarge { get; set; } = true;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Food[] myShoppingCart = new Food[]
            {
                new Pizza(),
                new Chips()
            };


            foreach (Food item in myShoppingCart)
            {
                Console.Write($"This item costs: {item.Price}, ");

                if (item is Pizza)
                {
                    Console.WriteLine($"My pizza has {((Pizza)item).NumOfToppings} toppings");
                }
                if (item is Chips)
                {
                    Console.WriteLine($"My chips is extraLarge: {((Chips)item).IsExtraLarge}");
                }

            }
        }
    }
}

```

Output:
```
This item costs: 20, My pizza has 2 toppings
This item costs: 20, My chips is extraLarge: True
```


# abstract function

```csharp
using System;

namespace app
{
    //Cannot create an instance of the abstract class
    //We can create a variable of the abstract class type - that can point to non-abstarct sub-class instance
    abstract class Food
    {
        public decimal Price { get; set; } = 20;

        //abstract function - is a decleration of a function - without the body
        //abstract function - can be only in abstarct class
        //abstract function - can not be private
        //every non-abstract sub-class must implement the inherited abstract member 
        public abstract string CookFood(int minutes);
    }


    class Pizza : Food
    {
        public int NumOfToppings { get; set; } = 2;

        public override string CookFood(int minutes)
        {
            return $"My pizza has {NumOfToppings} toppings, and is baked for {minutes} minutes";
        }
    }

    class Chips : Food
    {
        public bool IsExtraLarge { get; set; } = true;

        public override string CookFood(int minutes)
        {
            return $"My chips is extraLarge: {IsExtraLarge}, and is baked for {minutes} minutes";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Food[] myShoppingCart = new Food[]
            {
                new Pizza(),
                new Chips()
            };


            foreach (Food item in myShoppingCart)
            {
                Console.WriteLine(item.CookFood(12));
            }
        }
    }
}

```


Output:
```
My pizza has 2 toppings, and is baked for 12 minutes
My chips is extraLarge: True, and is baked for 12 minutes
```