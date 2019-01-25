


# polymorphism
```csharp
namespace _05_ovveride
{

    class A
    {

    }


    class B:A
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            A myA1 = new A();


            // a base can point to a sub instance
            A myA2 = new B();

            // a sub can not point to a base instance
            // B myB1 = new A();  //--> COMPILATION ERROR
            B myB2 = new B();
           
        }
    }
}

```
# polymorphism - can not access child property with parent pointer
```CSHARP
using System;

namespace _05_ovveride
{

    class A
    {
        public int Num1 { get; set; } = 1;
    }


    class B:A
    {
        public int Num2 { get; set; } = 2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            A myA = new B();

            Console.WriteLine(myA.Num1);

            //'A' does not contain a definition for 'Num2' 
            //Console.WriteLine(myA.Num2);  //CONPILATION ERROR

            B myB = new B();

            Console.WriteLine(myB.Num1);
            Console.WriteLine(myB.Num2);

        }
    }
}

```
OUTPUT:
```
1
1
2
```

# polymorphism - access child property with parent pointer by casting
```csharp
using System;

namespace _05_ovveride
{

    class A
    {
        public int Num1 { get; set; } = 1;
    }


    class B:A
    {
        public int Num2 { get; set; } = 2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            A myA = new B();

            if(myA is B)
            {
                Console.WriteLine(((B)myA).Num2);
            }

        }
    }
}

```
output:
```
2
```
