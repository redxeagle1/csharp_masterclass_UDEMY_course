# nullables

- a nullable is a variable that can be null or not and indicated by `T?` like `int?` `string?` ...etc
- nullable have special functions to it most common are `Value` to access the variable's value and `HasValue` which check if it's null or no
- nullable can't be implicitly casted into it non-nullable type i.e. `T` with being said it must be explicitly casted into other types

## null-coalescing operators

- nullable also comes with null-coalescing operator denoted by `??` which check if the value null if it's replace it with another value like the following example

    ```cs
    using System.Console;
    string? s = null;
    Console.WriteLine(s ?? "");
    ```

- null-coalescing operator can be written in form of assignment operator `=??`

## nullable use-cases

- nullables are useful for scenarios where you expect that the value may be missing or not enter
  - useful for databases
  - useful for form data

## nullable benefits

- safety: prevents runtime errors that can occur when dealing nullable types
- clarity:
  - mark any variable that can be null improving readability and maintainability
