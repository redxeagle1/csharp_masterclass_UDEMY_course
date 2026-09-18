## Delegates <!-- markdownlint-disable-line MD041 -->

- Definition: A blueprint for a method. It defines the return type and parameter list of any method it is allowed to point to.
- Purpose: Allows callbacks, event handling, and passing behavior into other methods.
- Built-in variations: Instead of writing custom delegates every time, .NET provides generic versions like `Action` (returns void) and `Func` (returns a value).
- it simply like dealing with methods in python

```py
def hi:
    print("something")

s = hi()

s()
```

- so as you see delegates are method pointers that accepts other method allowing us to store as a variable that can be called later on
- one of use cases are GUI Events

## Predicates

- A `Predicate<T>` is a built-in delegate type that represents a method returning a boolean. While it's perfect for filtering checks and used in traditional `List<T>` methods like `Find()` and `FindAll()`
- Rule: It must take exactly one input parameter of type `T` and must return a bool.
- Common Use: Searching or filtering collections using traditional `List<T>` methods (like `List<T>.Find`, `List<T>.FindAll`, and `List<T>.RemoveAll`).

> Note: Standard LINQ extension methods like `.Where()` use `Func<T, bool>`, not `Predicate<T>`.

```csharp
// A predicate that checks if a number is even
Predicate<int> isEven = n => n % 2 == 0;
bool result = isEven(4); // Returns true
```

- aside from that you can also make a function then pass it to the  predicate the same for the delegates

```cs
Predicate<int> isGreaterThanTen = IsGreaterThanTen;
public static bool IsGreaterThanTen(int x) => x > 10;
```
