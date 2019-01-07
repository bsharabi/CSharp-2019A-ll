# Delegate VS Event
## Delegate:
* Is to create a type that can point to function
* When we create a delegate in a class:
    * We can call the delegate directly from the instance
    * We can assign into the delegate a new function with `=` (will override all the prev values)
## Events:
* We add this word - before a delegate type property in a class
* When we create an event in a class:
    * We can not call the delegate directly from the instance
    * We can not assign into the delegate a new function with = (only with += or -=)


