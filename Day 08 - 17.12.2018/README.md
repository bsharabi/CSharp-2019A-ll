# Constructor only in the parent (without parameters)
```csharp
using System;

namespace _05_ovveride
{

    class A
    {
        public A()
        {
            Console.WriteLine("constructor of A");
        }
    }


    class B:A
    {
       
    }
    class Program
    {
        static void Main(string[] args)
        {

            B myB = new B();
           
        }
    }
}

```


output:
```
constructor of A
```


# Constructor in the parent and in the child (without parameters)
```csharp
using System;

namespace _05_ovveride
{

    class A
    {
        public A()
        {
            Console.WriteLine("constructor of A");
        }
    }


    class B:A
    {
        public B()
        {
            Console.WriteLine("constructor of B");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            B myB = new B();
           
        }
    }
}

```


output:
```
constructor of A
constructor of B
```
# Constructor in the parent and in the child (with parameters)
```csharp
using System;

namespace _05_ovveride
{

    class A
    {
        public A(int num1)
        {
            Console.WriteLine($"constructor of A , num1={num1}");
        }
    }


    class B:A
    {
        public B(int num1, int num2):base(num1)
        {
            Console.WriteLine($"constructor of B, num1={num1}, num2={num2}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            B myB = new B(3,6);
           
        }
    }
}
```

output:
```
constructor of A , num1=3
constructor of B, num1=3, num2=6
```
# Override
```csharp
using System;

namespace _05_ovveride
{

    class A
    {
        public string SayBye()
        {
            return " Bye I am A";
        }

        public string SayHello()
        {
            return " Hello I am A";
        }
    }


    class B:A
    {
        public string SayHello()
        {
            return " Hello I am B";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            B myB = new B();
            Console.WriteLine(myB.SayHello());
            Console.WriteLine(myB.SayBye());
        }
    }
}

```

output:
```
 Hello I am B
 Bye I am A
```


# Use `base` to access parent ovrrided function
```csharp
using System;

namespace _05_ovveride
{

    class A
    {
        public string SayBye()
        {
            return " Bye I am A";
        }

        public string SayHello()
        {
            return " Hello I am A";
        }
    }


    class B:A
    {
        public string SayHello()
        {
            return base.SayHello() + " Hello I am B";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            B myB = new B();
            Console.WriteLine(myB.SayHello());
            Console.WriteLine(myB.SayBye());
        }
    }
}

```
output:
```
 Hello I am A Hello I am B
 Bye I am A
```


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
