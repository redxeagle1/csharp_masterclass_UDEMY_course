# Modifiers

Modifiers are keywords that change the behavior of a `class`, method, or variable. They are divided into two main categories:

- **Access Modifiers:** These control who can see what (visibility and privacy). Examples include: `public`, `private`, `protected`, and `internal`.
- **Non-Access Modifiers:** These control how an element behaves in memory or interacts with inheritance. Examples include: `static`, `abstract`, `sealed`, `virtual`, and `readonly`.

The following subsections will clarify this topic in more detail.

## `Access` modifiers

### The `internal` modifier

- it make the class only accessible in the assemler level or in other word visible to the whole project or library

## `Non-access` modifiers

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
