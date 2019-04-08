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
