### implict casting (conversion) <!-- markdownlint-disable-line MD041 -->

- it's a process done by the compiler and does not need any special syntax and it happens when no there is no any data loss will occur
- examples of that are:
  - storing `int` inside a `double`, `float`, `long` since int hold smaller data width compared to the other types
- the implicit conversion won't happend if you tried to store a bigger data width inside a smaller container i.e.
  - `double` inside `float`
  - `long` that exceeded the `int`'s limit inside `int`

> note that c# compiler will warn you if you tried to cast something implicitly but it fails to do so resulting the Compiler Error CS0029: Cannot ***implicitly*** convert type 'type' to 'type'
> you can check the following link to know more about the implicit conversion [implicit conversions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/conversions#102-implicit-conversions)

### expilict casting (converion)

- it's done manually by the programmer and it does requre the cast expression `(T)E` where you explicitly cast from type `E` to type `T` as data loss or runtime erroe may occur during the process
- an example of that is casting a lenghthy `long` which it `64-bit` into `int` which is `32-bit` this will result an overlapping since c# priotrize performance over saftey it will cut the highest 32-bit and leave the least one and if the most highest bit happens to be 1 the 2's compliment operation will happen automaticly making the result negative converstion
- another one is casting from a `double` to `int` will trim the decimal point and what is after it
- even though you may think that every unimplicit conversion can be done explicitly you are very very wrong luckly for the c# compiler has a Compiler ERROR Coded CS0266 which notifies you if you need or can explicitly cast it

> you can check the following link to know more about the explicit conversion [explicit conversions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/conversions#103-explicit-conversions)

### Conversion Helpers `Parse` method, `Convert` class and `TryParse` method

1. `parse` is a method connected to the type's class itself like `int.Parse` or `bool.Parse` ...etc and it takes only string input and return that type
   - it throws `ArgumentNullException` upon a taking string with `null` assigned to it
   - it's only supported for certain types with customization available
   - generally speaking it throws exception and doesn't handle it so stick with `TryParse` as it auto handles the exception as illustrated in the last paragraph section
2. `Convert` it a class filled with a set of method for converting from types to other easily more flexiable than `parse` and much safer than it since it does handle the null arguments by making it the default value
  
   - it take object as input rather than string only
   - return the default value from the conversion of variable's null value to the other one or the target
   - support custom converion i.e casting from your types to another using (`IConvertible`)
here is a code for this

```c#
string baba = null;
int one_b = Convert.ToInt32(baba);
WriteLine(one_b);
```

> if you are sure that the conversion will through error plz use `TryParse` method and here is an example o using it
>
> ```c#
>string input = "123";
>// Declaring the out variable inside the method call (C# 7.0+)
>if (int.TryParse(input, out int result))
>{
>    Console.WriteLine($"Success! The number is {result}");
>}
> ```
>
> it handles the exception inside it
