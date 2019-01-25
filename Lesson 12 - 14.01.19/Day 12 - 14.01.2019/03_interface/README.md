
* Interface is only decleration without implementation
* Interface is called also `contract`


### Basic interface example
```csharp
using System;

namespace app
{   
    interface IMove
    {
        void MoveLeft(int speed);
        void MoveRight(int speed);
    }

    class Car : IMove
    {
        public void MoveLeft(int speed)
        {
            Console.WriteLine($"Car moves left in speed: {speed}");
        }

        public void MoveRight(int speed)
        {
            Console.WriteLine($"Car moves right in speed: {speed}");
        }
    }


    class Person : IMove
    {
        public void MoveLeft(int speed)
        {
            Console.WriteLine($"Person moves left in speed: {speed}");
        }

        public void MoveRight(int speed)
        {
            Console.WriteLine($"Person moves right in speed: {speed}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMove[] movingObjects = new IMove[] {
                new Car(),
                new Person()
            };

            foreach (IMove item in movingObjects)
            {
                item.MoveLeft(20);
            }
        }
    }
}

```
output:
```
Car moves left in speed: 20
Person moves left in speed: 20
```
### Multi interface example
```csharp
using System;

namespace app
{


    interface IRunnable
    {
        void Srart();
        void Srop();
    }

    interface IMove
    {
        void MoveLeft(int speed);
        void MoveRight(int speed);
    }

    class Car : IMove
    {
        public void MoveLeft(int speed)
        {
            Console.WriteLine($"Car moves left in speed: {speed}");
        }

        public void MoveRight(int speed)
        {
            Console.WriteLine($"Car moves right in speed: {speed}");
        }
    }


    class Person : IMove, IRunnable
    {
        public void MoveLeft(int speed)
        {
            Console.WriteLine($"Person moves left in speed: {speed}");
        }

        public void MoveRight(int speed)
        {
            Console.WriteLine($"Person moves right in speed: {speed}");
        }

        public void Srart()
        {
            Console.WriteLine($"Person starts to run");
        }

        public void Srop()
        {
            Console.WriteLine($"Person stops to run");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMove[] movingObjects = new IMove[] {
                new Car(),
                new Person()
            };

            foreach (IMove item in movingObjects)
            {
                item.MoveLeft(20);
            }


            IRunnable runnable = new Person();
            runnable.Srart();
        }
    }
}


```

output:
```
Car moves left in speed: 20
Person moves left in speed: 20
Person starts to run
```


### interface and abstarct - example
```csharp
using System;

namespace app
{
    interface IWash
    {
        string WashItem();
    }

    interface IWipe
    {
        string WipeItem();
    }


    abstract class HouseItem {
        public decimal Price { get; set; }
    }

    class Computer : HouseItem, IWipe
    {
        public string WipeItem()
        {
            return "Wipe the computer";
        }
    }


    class Tv : HouseItem, IWipe
    {
        public string WipeItem()
        {
            return "Wipe the Tv";
        }
    }


    class Floor : HouseItem, IWash
    {
        public string WashItem()
        {
            return "Wash the floor";
        }
        
    }


    class Dish : HouseItem, IWash, IWipe
    {
        public string WashItem()
        {
            return "Wash the Dish";
        }

        public string WipeItem()
        {
            return "Wipe the Dish";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            HouseItem[] itemsToClean = new HouseItem[]
            {
                new Computer(),
                new Tv(),
                new Floor(),
                new Dish()
            };


            foreach (HouseItem item in itemsToClean)
            {
                //check if the current instance is of a class that implements the "IWash" interface
                if(item is IWash)
                {
                    Console.WriteLine(((IWash)item).WashItem());
                }

                //check if the current instance is of a class that implements the "IWipe" interface
                if (item is IWipe)
                {
                    Console.WriteLine(((IWipe)item).WipeItem());
                }
            }



        }
    }
}

```

output:
```
Wipe the computer
Wipe the Tv
Wash the floor
Wash the Dish
Wipe the Dish
```

### implement interface in an abstarct class
```csharp
using System;

namespace app
{
    interface IWash
    {
        string WashItem();
        string DryItem();
    }

    /*
      מחלקה אבסטרקטית שמממשת ממשק, יכולה לממש אותו באחת משני הדרכים הבאות

           - מימוש מלא - כלומר נכתוב את גוף הפונקציה
           - הגדרת הפונקציה שיש לממש מהממשק - כפונקציה אבסרקטית , שהיורשים יצטרכו לממש
    */
    abstract class HouseItem : IWash
    {

        public string DryItem()
        {
            return "Dry HouseItem";
        }

        public abstract string WashItem();
    }


    class Dish : HouseItem
    {
        public override string WashItem()
        {
            return "Wash the Dish";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {


            HouseItem myHouseItem = new Dish();
            Console.WriteLine(myHouseItem.WashItem());
            Console.WriteLine(myHouseItem.DryItem());

        }
    }
}

```
output:
```
Wash the Dish
Dry HouseItem
```