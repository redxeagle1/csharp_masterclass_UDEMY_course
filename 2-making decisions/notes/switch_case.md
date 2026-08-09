# `switch`

- The `switch` statement is different from the `if` statement because `switch` compares a ***single expression*** against ***a list of multiple possible case statements***. Every case statement is related ***to the single expression***. Every case section must end with one of the following:

1. The `break` keyword (like case 1 in the following code).
2. The `goto` `case` keywords (like case 2 in the following code).
3. They should have no statements (like case 3 in the following code).
4. The `goto` keyword that references a named label (like case 5 in the following code).
5. The `return` keyword to leave the current function (not shown in the code).

> yes you can use the goto keyword to jump to another case or a label. The goto keyword is frowned upon by most programmers but can be a good solution to code logic in some scenarios. However, you should use it sparingly

- an example of a typical `switch` statement is the following code

    >```C#
    > int number = Random.Shared.Next(minValue: 1, maxValue: 7);
    > WriteLine($"My random number is {number}");
    > switch (number)
    > {
    >   case 1:
    >     WriteLine("One");
    >     break; // Jumps to end of switch statement.
    >   case 2:
    >     WriteLine("Two");
    >     goto case 1;
    >   case 3: // Multiple case section.
    >   case 4:
    >     WriteLine("Three or four");
    >     goto case 1;
    >   case 5:
    >     goto A_label;
    >   default:
    >     WriteLine("Default");
    >     break;
    > } // End of switch statement.
    > WriteLine("After end of switch");
    > A_label:
    > WriteLine($"After A_label");
    >```
    >
    > notice how do we compare the `number` variable with a full list of cases
    > the `default` keyword in this context is acting like the `else` statement and it's executed if no cases fullfil the variable

![best switch use cases](./media/best%20switch%20use%20cases.png)

> it also more performative than `if` in some cases

- you can write switch cases more concise via switch expression which doesn't need explicit `break` or `case` but you will still use the `default` keyword replace by `_`

```c#
DayOfWeek today = DayOfWeek.Saturday;

// Regular switch expression mapping constants to a string
string schedule = today switch
{
    DayOfWeek.Monday    => "9:00 AM - 5:00 PM",
    DayOfWeek.Wednesday => "9:00 AM - 8:00 PM (Extended Hours)",
    DayOfWeek.Friday    => "9:00 AM - 1:00 PM (Half Day)",
    DayOfWeek.Saturday  => "Closed",
    DayOfWeek.Sunday    => "Closed",
    
    _ => "9:00 AM - 6:00 PM" // Default fallback for Tuesday and Thursday
};

Console.WriteLine($"Today's hours: {schedule}");

```

## pattern matching

- same as if but can be done via 2 appoaches

### pattern matching in the standerd method <!-- markdownlint-disable-line MD001 -->

- This approach uses traditional case blocks, explicitly declares type variables inline, and requires break statements.

```c#
object input = 42.5f; // Can hold any type

switch (input)
{
    // Match an integer and check its value
    case int i when i > 100:
        Console.WriteLine($"Large Integer: {i}");
        break;
    case int i:
        Console.WriteLine($"Regular Integer: {i}");
        break;

    // Match a float and apply a relational check
    case float f when f < 0.0f:
        Console.WriteLine($"Negative Float: {f}");
        break;
    case float f:
        Console.WriteLine($"Positive/Zero Float: {f}");
        break;

    // Match a string and check for specific text or emptiness
    case string s when string.IsNullOrWhiteSpace(s):
        Console.WriteLine("Empty or white space string.");
        break;
    case string s:
        Console.WriteLine($"String text: {s}");
        break;

    // Default case if none of the above match
    case null:
        Console.WriteLine("The input is null.");
        break;
    default:
        Console.WriteLine("Unknown data type.");
        break;
}
```

### pattern marching with `swtch` expression

- This modern approach returns a value directly, eliminates case and break keywords, and uses the discard pattern (_) for the default case.

```c#
object input = "Hello C#";

string result = input switch
{
    // Match int with a condition
    int i when i > 100 => $"Large Integer: {i}",
    int i              => $"Regular Integer: {i}",

    // Match float with a condition
    float f when f < 0.0f => $"Negative Float: {f}",
    float f               => $"Positive/Zero Float: {f}",

    // Match string with a condition
    string s when s.Length == 0 => "Empty string",
    string s                    => $"String text: {s}",

    // Handle null and default fallback
    null => "The input is null.",
    _    => "Unknown data type." // The underscore acts as 'default'
};

Console.WriteLine(result);

```
