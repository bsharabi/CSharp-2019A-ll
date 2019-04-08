# `Override` 
```csharp
using System;
namespace app
{

    class A
    {
        public void Test()
        {
            Console.WriteLine("I am A");
        }
    }

    class B:A
    {
        public void Test()
        {
            Console.WriteLine("I am B");
        }
    }

    class C:A
    {
        public void Test()
        {
            Console.WriteLine("I am C");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //pointer is type A - points to an object of class A   
            A myA1 = new A();

            //pointer is type A - points to an object of class B
            A myA2 = new B();

            //pointer is type A - points to an object of class C
            A myA3 = new C();


            myA1.Test();  //--> I am A
            myA2.Test();  //--> I am A
            myA3.Test();  //--> I am A



            //pointer is type B - points to an object of class B
            B myB = new B();

            //pointer is type C - points to an object of class C
            C myC = new C();

            myB.Test();  //--> I am B
            myC.Test();  //--> I am C

        }
    }
}

```

*Note* : By default - if there is in the base class and in the sub class a function with the same name - the execution of this function will be according to the pointer type. 
* If a pointer of type `base` point to `sub` - the execution of this function will be the `base` function
* If a pointer of type `sub` point to `sub` - the execution of this function will be the `sub` function


# `virtual` and `override`
* If we declare a function with the `virtual` keyword in the base calss- we can override it in the sub class
* `override` can be declared when the base is `virtual` or `override`
```csharp
using System;
namespace app
{


    class A
    {
        public virtual void Test()
        {
            Console.WriteLine("I am A");
        }
    }

    class B:A
    {
        public override void Test()
        {
            Console.WriteLine("I am B");
        }
    }

    class C:A
    {
        public void Test()
        {
            Console.WriteLine("I am C");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            A myA1 = new A();
            A myA2 = new B();
            A myA3 = new C();


            myA1.Test();  //--> I am A
            myA2.Test();  //--> I am B
            myA3.Test();  //--> I am A


            B myB = new B();
            C myC = new C();

            myB.Test();  //--> I am B
            myC.Test();  //--> I am C

        }
    }
}

```

# `virtual` and `new`
If there is in the base class and in the sub class a function with the same name - and we do not want to ovrride the base function in the sub class - it is recommended to add the `new` keyword in the function that we write in sub class. (it will work the same without the `new` keyword)
```csharp
using System;
namespace app
{


    class A
    {
        public virtual void Test()
        {
            Console.WriteLine("I am A");
        }
    }

    class B:A
    {
        public override void Test()
        {
            Console.WriteLine("I am B");
        }
    }

    class C:A
    {
        public new void Test()
        {
            Console.WriteLine("I am C");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            A myA1 = new A();
            A myA2 = new B();
            A myA3 = new C();


            myA1.Test();  //--> I am A
            myA2.Test();  //--> I am B
            myA3.Test();  //--> I am A


            B myB = new B();
            C myC = new C();

            myB.Test();  //--> I am B
            myC.Test();  //--> I am C

        }
    }
}
```

# Multi level - overriding
### Example 1:
```csharp
using System;
namespace app
{


    class A
    {
        public virtual void Test()
        {
            Console.WriteLine("I am A");
        }
    }

    class B:A
    {
        public override void Test()
        {
            Console.WriteLine("I am B");
        }
    }

    class C:B
    {
        public new void Test()
        {
            Console.WriteLine("I am C");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            A myA1 = new A();
            A myA2 = new B();
            A myA3 = new C();


            myA1.Test();  //--> I am A
            myA2.Test();  //--> I am B
            myA3.Test();  //--> I am B 


            B myB1 = new B();
            B myB2 = new C();

            myB1.Test();  //--> I am B
            myB2.Test();  //--> I am B

            C myC = new C();

            myC.Test();  //--> I am C

        }
    }
}

```

### Example 2:
```csharp
using System;
namespace app
{


    class A
    {
        public virtual void Test()
        {
            Console.WriteLine("I am A");
        }
    }

    class B:A
    {
        public override void Test()
        {
            Console.WriteLine("I am B");
        }
    }

    class C:B
    {
        public override void Test()
        {
            Console.WriteLine("I am C");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            A myA1 = new A();
            A myA2 = new B();
            A myA3 = new C();


            myA1.Test();  //--> I am A
            myA2.Test();  //--> I am B
            myA3.Test();  //--> I am C 


            B myB1 = new B();
            B myB2 = new C();

            myB1.Test();  //--> I am B
            myB2.Test();  //--> I am C

            C myC = new C();

            myC.Test();  //--> I am C

        }
    }
}

```


# sealed
```csharp

using System;
namespace app
{


    class A
    {
        public virtual void Test()
        {
            Console.WriteLine("I am A");
        }
    }

    class B : A
    {

        //every sub class of this class - cannot override this function because it is sealed	
        public sealed override void Test()
        {
            Console.WriteLine("I am B");
        }
    }

    class C : B
    {
        public new void Test()
        {
            Console.WriteLine("I am C");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            A myA1 = new A();
            A myA2 = new B();
            A myA3 = new C();


            myA1.Test();  //--> I am A
            myA2.Test();  //--> I am B
            myA3.Test();  //--> I am B


            B myB1 = new B();
            B myB2 = new C();

            myB1.Test();  //--> I am B
            myB2.Test();  //--> I am B

            C myC = new C();

            myC.Test();  //--> I am C

        }
    }
}

```
