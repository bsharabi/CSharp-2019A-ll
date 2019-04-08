# Sealed class 
Cannot derive from sealed class - so each time when we want to create a class that we can create an instance of this class - but not derive from this class - we will declare the class as a `sealed`.

Example:
```csharp
using System;

namespace app
{

    //Can create an instance of the class 'A'
    //can derive from type 'A'
    //can declare instance members + static nenber in this class 
    //can declare non-static + static constructor in a this class 
    class A { }
    class B :A { }


    //cannot derive from static class 'C'	
    //Cannot create an instance of the static class 'C'	
    //cannot declare instance members in a static class 
    //cannot declare non-static constructor in a static class 
    static class C { }


    //Can create an instance of the sealed class 'D'
    //cannot derive from sealed type 'D'
    //can declare instance members in a sealed class 
    //can declare non-static constructor in a sealed class 
    sealed class D {
        public int MyProperty { get; set; } = 5;
    }


    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            Console.WriteLine(d.MyProperty);  //--> 5
        }
    }
}

```