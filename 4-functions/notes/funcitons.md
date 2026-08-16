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

    > parameter can be either a variable or a value
    > parameter are optional so any method may contain no parameters

- `method body`: is the code to be executed
- `return` if a method has a `<ReturnType>` it return values `29493` or expressions `a + b` that does evaluates to values

## methood calling and location

- to call a funciton you need to type the functoin name and pass arguments if specified
  > arguments and parameter refers to the same thing like a person can be both a parent and a doctor but arguments are the data you pass into the method’s parameters. while parameters are the variables in a function definition.
