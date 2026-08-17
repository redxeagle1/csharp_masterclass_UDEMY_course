# functions or methods (preferably as best practise)

- methods is a code block contains multiple series of. A program then cause these statements to be executed by calling the method (invokation) and specifying arguments
- method are reusable too

## method struncture

```c#
<AccessModifier> <ReturnType> <MethodName>(<ParameterLisr>)
{
    // method body (code to execute)
    return <value>; // Required if ReturnType is not 'void'
}
```

- `<AccessModifier>` : defines the visibilty of a variable or a method from another class like `static` `public` `private` `protected internal` `internal` `protected` `private protected`
- `<ReturnType>`
  - method can either return a value which will require identifying the type of the return the for example a method can be a `int` type so ***it should return a `int` value***

      > ```c#
      > int SumOfTwo(int firstNum, int secondNum)
      > {
      >     return firstNum + secondNum;
      > }
      > ```

  - method return nothing which will be from type `void`

      >```c#
      > void SayHello(string name)
      > {
      >     WriteLine($"hello mello mister {name}");
      > }
      > 
      >```

- `<MethodName>`: a unique identifier and case sensitive follows Pascal case (`MyClassAnimal`) naming convention
- `<ParameterLisr>`: enclosed between parentheses, the prameters are used to pass and recieve data from a method the parameter list order refer to
  - type
  - order
  - number of parameters in the list
- arguments and parameter refers to the same thing like a person can be both a parent and a doctor but arguments are the data you pass into the method’s parameters. while parameters are the variables in a function definition.
- arguments when passing them can be implicitly casted but you must refer to the official documentation that discuss the supported implicit casting and this is also discussed in the casting note and that is called `argument promotion`

  > - parameter can be either a variable or a value
  > - parameter are optional so any method may contain no parameters

- `method body`: is the code to be executed
- `return` if a method has a `<ReturnType>` it return values `29493` or expressions `a + b` that does evaluates to values

### `<Parameter Modifiers>`

- this are use so parameter can change how arguments are passed to methods, allowing us to pass data more efficiently or control how values are modified inside a method.

- there multiple Parameter Modifiers
  - `pass-by-value` ***the default parameter modifier*** which means a copy of the argument's data is sent to the method. so modify it will not affect the original argument

    >```c#
    > int a = 4;
    > int b = 6;
    > int result = SumOfTwo(a,b);
    > WriteLine($"{nameof(a)} : {a}"); // a : 4  
    > int SumOfTwo(int firstNum, int secondNum)
    > {
    >     return firstNum + secondNum;
    > }
    >```
  
  - `pass-by-refrence` using the `ref` keyword in which The method receives a direct reference to the memory location. Any changes made inside the method will permanently alter the original variable outside the method.
    - The variable must be initialized by the caller before invoking the method.

    > ```c#
    > int a = 4;
    > int b = 6;
    > WriteLine($"{nameof(a)} [before] : {a}"); // a [before] : 4
    > int result = SumOfTwoDoubled(ref a,ref b);
    > WriteLine($"{nameof(a)} [after] : {a}"); // a [after] : 8
    > int SumOfTwo(int firstNum, int secondNum)
    > {
    >     return firstNum + secondNum;
    > }
    > ```
    >
    > - notice that we must prefix both argument with the `ref` keyword not doing so will throw an error

  - `Output Reference` using the `out` keyword : The called method must assign a value to this parameter before the method returns, or a compile error occurs. It is commonly used to return multiple values from a single function.
    - The caller does not need to initialize the variable beforehand.

    > ```c#
    > void Calculate(int x, int y, out int sum, out int product)
    > {
    >     sum = x + y;
    >     product = x * y;
    > }
    > 
    > int a = 5, b = 3, sum, product;
    > Calculate(a, b, out sum, out product);
    > Console.WriteLine($"Sum: {sum}, Product: {product}");
    > // Output: Sum: 8, Product: 15
    > ```

  - `Read-Only Reference` using the `in` keyword : It passes the argument by reference to improve performance (especially helpful for large `struct` objects to avoid memory copying overhead).
    - The called method cannot modify the parameter (value or the passed argument); attempting to change it results in a compile-time error
    - The variable must be initialized before being passed.

    > ```c#
    > void PrintValue(in int number)
    > {
    >     Console.WriteLine(number); // Allowed
    >     // number += 10; // Not allowed (will cause a compile error)
    > }
    > 
    > int myNumber = 100;
    > PrintValue(in myNumber);
    > ```

- When to Use Each Modifier?
  - Use ref when you need a method to modify an existing variable.
  - Use out when you need a method to return multiple values.
  - Use in when passing large objects that should not be modified.

- Best Practices and Common Mistakes
  - Best Practices
    - Use ref only when necessary to avoid unintended side effects.
    - Use out for returning multiple values cleanly.
    - Use in for performance benefits when passing large structs.
  - Common Mistakes
    - Forgetting to initialize ref variables before passing them.
    - Not assigning a value to an out parameter inside the method.
    - Trying to modify an in parameter (which is read-only).

## methood calling and location

- to call a funciton you need to type the functoin name and pass arguments if specified
- function must be defined in the bottom of any top-level program

## methods and local functions

- when defining a function inside a method it's called `local function`
  
  > like for example
  >
  > ```c#
  >  static void Main(string[] args) // method
  >  {
  >      WriteLine("Hello, World!");
  >      string myname() // local function
  >      {
  >          return "red";
  >      }
  >  }
  > ```

- here is a quich comparasion between both ***Standard Method*** and ***Local Function***

  > |Feature|Standard Method|Local Function|
  > |---|---|---|
  > |**Scope**|Class-level (accessible by any class member).|Block-level (only accessible inside the parent member).|
  > |**Access Modifiers**|Can use `public`, `private`, `protected`, etc.|No modifiers allowed (implicitly private to the block).|
  > |**Variable Access**|Can access class-level fields.|Can directly capture local variables of the parent method.|
  > |**Nesting**|Cannot be nested inside other methods.|Can be nested inside methods, properties, constructors, or other local functions.|
  > |**usability**|usable on the class-level such as `Console.WriteLine()` and can be used in the class's instance too such as `human.run()`|only can be used in the block level in other word the method it defined inside or the parent method|

> - another thing to note is that unlike method local funciton cannot be documented via doc string
