# Overloading
```csharp
using System;

namespace _02_generics
{
    class Program
    {
        static bool IsEq(int n1, int n2)
        {
            return n1 == n2;
        }


        static bool IsEq(string n1, string n2)
        {
            return n1 == n2;
        }


        static bool IsEq(bool n1, bool n2)
        {
            return n1 == n2;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(IsEq(2,2));
            Console.WriteLine(IsEq("bob", "bob"));
            Console.WriteLine(IsEq(true, true));

        }
    }
}
```


# Generic
```csharp
using System;

namespace _02_generics
{
    class Program
    {
        static void IsEq<T>(T n1, T n2)
        {
            Console.WriteLine($"n1 = {n1} , n2 = {n2} ");
        }

        static void Main(string[] args)
        {

            IsEq(2,2);
            IsEq("bob", "bob");
            IsEq(true, true);

        }
    }
}

```


output:
```
n1 = 2 , n2 = 2
n1 = bob , n2 = bob
n1 = True , n2 = True
```


# Generics - withe few types - implicit call
```csharp
using System;

namespace _02_generics
{
    class Program
    {
        static void IsEq<T,S>(T n1, S n2)
        {
            Console.WriteLine($"n1 = {n1} , n2 = {n2} ");
        }

        static void Main(string[] args)
        {
            //IS CALLED AS: static void IsEq<int,string>(int n1, string n2)
            IsEq(2, "bob");


            //IS CALLED AS: static void IsEq<string,bool>(string n1, bool n2)
            IsEq("bob", false);

        }
    }
}

```
output:
```
n1 = 2 , n2 = bob
n1 = bob , n2 = False
```

# Generic - Explicit call
```csharp
using System;

namespace _02_generics
{
    class Program
    {
        static void IsEq<T,S>(T n1, S n2)
        {
            Console.WriteLine($"n1 = {n1} , n2 = {n2} ");
        }

        static void Main(string[] args)
        {
            //IS CALLED AS: static void IsEq<int,string>(int n1, string n2)
            IsEq<int, string>(2, "bob");


            //IS CALLED AS: static void IsEq<string,bool>(string n1, bool n2)
            IsEq<string, bool>("bob", false);

        }
    }
}

```
output:
```
n1 = 2 , n2 = bob
n1 = bob , n2 = False
```



# Generic - with rules 
```csharp
namespace _02_generics
{

    class Person { }

    class Student : Person { }

    class Cat { }


    class Program
    {

        /*
            T must be or class "Person" or a sub-class of "Person"
        */
        static void Test<T>(T n1) where T : Person
        {

        }

        static void Main(string[] args)
        {
            Test(new Person());
            Test(new Student());
            //Test(new Cat());  --> COMPILATION ERROR

        }
    }
}

```


# Generic class
```csharp
namespace _02_generics
{
    class Sms<T>
    {
        public string PhoneAddressee { get; set; }
        public T Msg { get; set; }

        public void SendSms()
        {
            System.Console.WriteLine($"Sending to {PhoneAddressee}, msg: {Msg}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Sms<int> sms1 = new Sms<int>();
            sms1.Msg = 3;
            sms1.PhoneAddressee = "0553335566";
            sms1.SendSms();

            Sms<string> sms2 = new Sms<string>();
            sms2.Msg = "HAVE A PERFECT DAY";
            sms2.PhoneAddressee = "0551115566";
            sms2.SendSms();

        }
    }
}

```
output:
```
Sending to 0553335566, msg: 3
Sending to 0551115566, msg: HAVE A PERFECT DAY
```


# Generic class - implicit call
```csharp
namespace _02_generics
{
    class Sms<T>
    {
        public string PhoneAddressee { get; set; }
        public T Msg { get; set; }


        public Sms(T msg)
        {
            Msg=msg;
        }
        
        public void SendSms()
        {
            System.Console.WriteLine($"Sending to {PhoneAddressee}, msg: {Msg}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Sms<int> sms1 = new Sms(3);
            sms1.PhoneAddressee = "0553335566";
            sms1.SendSms();

            Sms<string> sms2 = new Sms("HAVE A PERFECT DAY");
            sms2.PhoneAddressee = "0551115566";
            sms2.SendSms();

        }
    }
}

```
output:
```
Sending to 0553335566, msg: 3
Sending to 0551115566, msg: HAVE A PERFECT DAY
```



# Generic class - explicit call
```csharp
namespace _02_generics
{
    class Sms<T>
    {
        public string PhoneAddressee { get; set; }
        public T Msg { get; set; }


        public Sms(T msg)
        {
            Msg=msg;
        }
        
        public void SendSms()
        {
            System.Console.WriteLine($"Sending to {PhoneAddressee}, msg: {Msg}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Sms<int> sms1 = new Sms<int>(3);
            sms1.PhoneAddressee = "0553335566";
            sms1.SendSms();

            Sms<string> sms2 = new Sms<string>("HAVE A PERFECT DAY");
            sms2.PhoneAddressee = "0551115566";
            sms2.SendSms();

        }
    }
}

```
output:
```
Sending to 0553335566, msg: 3
Sending to 0551115566, msg: HAVE A PERFECT DAY
```
