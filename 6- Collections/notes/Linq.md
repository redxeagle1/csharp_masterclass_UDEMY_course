# Linq

- Linq is short for Language Integrated Query
- It help in find,sort and filtering data
- it reduce the need for loops shortening the boilerplate code needed to do something
- it works with list, arrays, databases and more
- it usually pairs with Lambda expressions, Delegates and predicates
- it always return `IEnumerable<T>`

## what is `IEnumerable`

- `IEnumerable` is a foundational `interface` in .NET that represents a forward-only, read-only collection of elements that can be looped through.
- It acts as the backbone for all collection types in C# and is the primary type used by LINQ to Objects.

### How It Works Under the Hood

- The `IEnumerable` interface is incredibly simple. It contains just **one method**:

  - `GetEnumerator()`: This method returns an `IEnumerator` object.

- The `IEnumerator` object is what actually does the heavy lifting of tracking the current position in the collection. It contains:
  - `MoveNext()`: Moves forward to the next item (returns `false` if it reaches the end).
  - `Current`: Holds the item at the current position.
  - `Reset()`: Moves back to the beginning.

### It Has Two Versions

| Version | Namespace | Description |
| --- | --- | --- |
| **`IEnumerable<T>`** (Generic) | `System.Collections.Generic` | **Type-safe** (highly recommended). You know exactly what type of object is inside (e.g., `IEnumerable<string>`). |
| **`IEnumerable`** (Non-Generic) | `System.Collections` | **Legacy/Untyped**. Treats everything as a generic `object`. Used mostly in older .NET framework code. |

Key Characteristics

- **Deferred Execution (Lazy Evaluation):** When a LINQ query returns an `IEnumerable`, the data is not actually retrieved or processed yet. The calculation only runs when you start looping through it (e.g., using a `foreach` loop or calling `.ToList()`).
- **Read-Only:** You can read data out of it, but you cannot add, remove, or modify items directly through the interface itself.
- **Forward-Only:** You can only move from start to finish. You cannot jump to a specific index (like `list[5]`) without looping up to that point.

## Core Method

- filtering using `Where()`

    ```cs
    using System.Linq;

    List<int> numbers = new List<int>(100);
    Random random = new();
    for(int i = 0; i < 100;i++)
    {
        numbers.Add(random.Next(0,1000));
    }

    List<int> lessThanNumbers = numbers.Where(x => x < 100).ToList();
    ```

    > the `.ToList()` and `ToSomeThing()` are family of conversions used to convert IEnumerable into other collection type
