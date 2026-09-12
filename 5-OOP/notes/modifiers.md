# Modifiers

Modifiers are keywords that change the behavior of a `class`, method, or variable. They are divided into two main categories:

- **Access Modifiers:** These control who can see what (visibility and privacy). Examples include: `public`, `private`, `protected`, and `internal`.
- **Non-Access Modifiers:** These control how an element behaves in memory or interacts with inheritance. Examples include: `static`, `abstract`, `sealed`, `virtual`, and `readonly`.

The following subsections will clarify this topic in more detail.

## `Access` modifiers

### The `internal` modifier

- it make the class only accessible in the assembler level or in other word visible to the whole project or library

### The `public` modifier

- makes our members accessible outside the class level making it convenient when you want to share your methods with other classes for example

### The `private` modifier

- makes our members only visible to the class-level making it convenient when you want to hide your attributes, method that you don't want any other class to use.

## `Non-access` modifiers

### The `const` Modifier

- Hardcoded at Build: The compiler copies and pastes the raw value directly into the code wherever it is used.
- Immediate Initialization: You must assign a value the exact moment you declare it.
- Never Changes: The value is strictly immutable and cannot be altered at runtime.
- Implicitly Static: Class-level constants belong to the class itself, not to individual instances.
- Limited Types: Only works with primitives (`int`, `float`, etc.), `string`, `enum`, or a `null` reference.

    ```C#
    public class MathConstants
    {
        // Class-level compile-time constants
        public const double Pi = 3.14159;
        public const int MaxUsers = 100;
    
        public void Calculate()
        {
            // Local constant inside a method
            const string Greeting = "Hello World";
            
            // Greeting = "New String"; // This line would cause a compile error!
        }
    }

    ```

### The `readonly` Modifier

- a keyword primarily used to declare that a field can only be assigned a value during its declaration or within a constructor of the same class.
- It acts as a safeguard to ensure data integrity and to create immutable data structures
- The impact of readonly depends heavily on the type of data it holds
  - Value Types (e.g., int, bool, custom structs): The field becomes completely immutable. The value cannot be changed.
  - Reference Types (e.g., custom classes, lists, arrays): The field must always point to the same object instance. You cannot reassign the field to a new object, but you can still modify the internal properties of that object
`readonly` vs `const`

- Developers often confuse  

#### The key differences between `readonly` and `const` are

| Feature             | `readonly`                                                      | `const`                                             |
| ------------------- | --------------------------------------------------------------- | --------------------------------------------------- |
| **Evaluation Time** | **Runtime** constant (value can be determined during execution) | **Compile-time** constant (value must be hardcoded) |
| **Initialization**  | At declaration OR inside constructors                           | Only at declaration                                 |
| **Supported Types** | Any type (Value types and Reference types)                      | Only primitive types, enums, or strings             |
| **Scope**           | Class fields only (cannot be used inside methods)               | Can be declared inside local methods or classes     |

- it's useful when you need for example an id for each object of a certain class

### The `static` Modifier

- The `static` keyword is a non-access modifier that makes a variable or method inside a `class` operate at the class level itself. This means you do not need to create an object (instance) of that `class` to use it. Instead, you can call the variable or method directly through the `class`.
- For example, in C#, to use the built-in math library, you don't need to instantiate an object named `math` to work with its functions:

```c#
// The Math class in C# is static. You call its methods directly.
// CORRECT
Console.WriteLine(Math.Sqrt(9)); 

// WRONG (This will actually cause a compiler error in C#)
Math myMath = new Math();
```

#### A Real-World Analogy

- Think of it like being a builder who has created a single blueprint for the houses you plan to construct—this blueprint represents the `class`.
  - **The Object:** Each individual house built from that blueprint is an `object`. It has its own unique properties, such as the color of the walls, the furniture, and other specific details.
  - **The Static Element:** However, all the houses built will share a common property or unified actions that apply uniformly to all of them. In this context, that "unified" or shared element is exactly what `static` represents.

#### `static` Usage Considerations

- Memory Usage: Static members are allocated once and live for the duration of the application, which can be more memory-efficient for shared data.
- Global State: Static members maintain a global state which can lead to issues with data consistency, especially in multithreaded scenarios. Care should be taken to manage access to static members, possibly using synchronization mechanisms if needed.
- Testing Challenges: Classes that use static members can be harder to test due to their persistent state across tests. This can be mitigated by using patterns such as dependency injection to abstract away static dependencies.
