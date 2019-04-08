### Without Exception

```csharp
using System;

namespace _00_basic_try_and_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "2";

            try
            {
                Console.WriteLine("Here we start try");

                //int.Parse - Converts the string to int (will fail if string contains non-digit chars)
                int num = int.Parse(str);

                Console.WriteLine("Here we end try");
            }
            catch (FormatException)
            {
                Console.WriteLine("Here we are in catch");
            }

            Console.WriteLine("Here we are after try- catch");

        }
    }
}
```
output:
```
Here we start try
Here we end try
Here we are after try- catch
```

### With Exception

```csharp
using System;

namespace _00_basic_try_and_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "a";

            try
            {
                Console.WriteLine("Here we start try");

                //int.Parse - Converts the string to int (will fail if string contains non-digit chars)
                int num = int.Parse(str);

                Console.WriteLine("Here we end try");
            }
            catch (FormatException)
            {
                Console.WriteLine("Here we are in catch");
            }

            Console.WriteLine("Here we are after try- catch");

        }
    }
}

```


```
Here we start try
Here we are in catch
Here we are after try- catch
```


### Catch bt exception type - example 1
```csharp
using System;

namespace _00_basic_try_and_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "a";

            try
            {
                Console.WriteLine("Here we start try");
                int num = int.Parse(str);
                Console.WriteLine("Here we end try");
            }


            //this "catch" will catch all the Exceptions 
            //that are from "OutOfMemoryException" or sub-class of "OutOfMemoryException"
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Here we are in OutOfMemoryException catch");
            }

            //If Exception was not catched in a A previous catch clause 
            //this "catch" will catch all the Exceptions (because all exceptions are sub-classes of "Exception") 
            catch (Exception)
            {
                Console.WriteLine("Here we are in Exception catch");
            }

            Console.WriteLine("Here we are after try- catch");

        }
    }
}

```
output
```
Here we start try
Here we are in Exception catch
Here we are after try- catch
```

### Catch bt exception type - example 2
```csharp
using System;

namespace _00_basic_try_and_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "a";

            try
            {
                Console.WriteLine("Here we start try");
                int num = int.Parse(str);
                Console.WriteLine("Here we end try");
            }


            //this "catch" will catch all the Exceptions 
            //that are from "FormatException" or sub-class of "FormatException"
            catch (FormatException)
            {
                Console.WriteLine("Here we are in FormatException catch");
            }

            //If Exception was not catched in a A previous catch clause 
            //this "catch" will catch all the Exceptions (because all exceptions are sub-classes of "Exception") 
            catch (Exception)
            {
                Console.WriteLine("Here we are in Exception catch");
            }

            Console.WriteLine("Here we are after try- catch");

        }
    }
}

```
output
```
Here we start try
Here we are in FormatException catch
Here we are after try- catch
```


### access Exception properties

```csharp
using System;

namespace _00_basic_try_and_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "a";

            try
            {
                Console.WriteLine("Here we start try");
                int num = int.Parse(str);
                Console.WriteLine("Here we end try");
            }



            //if we want to access the properties of the exception - we will declare a variable that will get the thrown exception
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception)
            {
                Console.WriteLine("Here we are in Exception catch");
            }

            Console.WriteLine("Here we are after try- catch");

        }
    }
}

```
output:
```
Here we start try
Input string was not in a correct format.
Here we are after try- catch
```


### Finally - example (with exception)
```csharp
using System;

namespace _00_basic_try_and_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "a";

            try
            {
                Console.WriteLine("Here we start try");
                int num = int.Parse(str);
                Console.WriteLine("Here we end try");
            }


            //this "catch" will catch all the Exceptions 
            //that are from "FormatException" or sub-class of "FormatException"
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //If Exception was not catched in a A previous catch clause 
            //this "catch" will catch all the Exceptions (because all exceptions are sub-classes of "Exception") 
            catch (Exception)
            {
                Console.WriteLine("Here we are in Exception catch");
            }
            finally
            {
                Console.WriteLine("finally runs allwayes");
            }

            Console.WriteLine("Here we are after try- catch");

        }
    }
}

```
output:
```
Here we start try
Input string was not in a correct format.
finally runs allwayes
Here we are after try- catch
```


### Finally - example (without exception)
```csharp
using System;

namespace _00_basic_try_and_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "2";

            try
            {
                Console.WriteLine("Here we start try");
                int num = int.Parse(str);
                Console.WriteLine("Here we end try");
            }


            //this "catch" will catch all the Exceptions 
            //that are from "FormatException" or sub-class of "FormatException"
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //If Exception was not catched in a A previous catch clause 
            //this "catch" will catch all the Exceptions (because all exceptions are sub-classes of "Exception") 
            catch (Exception)
            {
                Console.WriteLine("Here we are in Exception catch");
            }
            finally
            {
                Console.WriteLine("finally runs allwayes");
            }

            Console.WriteLine("Here we are after try- catch");

        }
    }
}

```
output:
```
Here we start try
Here we end try
finally runs allwayes
Here we are after try- catch
```

### Why to use Finally 
If we have a `return` in the try or `catch` - the `finally` will still run