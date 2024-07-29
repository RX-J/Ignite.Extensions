# The Ignite.Extensions contains some helpful functions with the goal to make code more readable and clean.

**To use the ```Pipe``` function, you can write:**

```cs
using System;
using Ignite.Extensions;

Console.Write ("Enter a number: ");
Console.ReadLine ()
       .Pipe (int.Parse) // the input from the Console.ReadLine() function will get passed down to the int.Parse function
       .Pipe (i => i + 10) // from there we create the function, which adds 10 to the value of the parsed value from before
       .Pipe (Console.WriteLine); // finally we take that value and send it to the Console.WriteLine function, which will print the final value

// this is a good alternative for instead of having to write:

Console.Write ("Enter a number: ");
Console.WriteLine (int.Parse (Console.ReadLine ()) + 10);
```