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
