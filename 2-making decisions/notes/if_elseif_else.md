# `if`

- every application alogrithm need to make decisions such as identify if a user need to log in or not or if he has already an account
- the two primary selection statements are `if` and `switch`

```c#
if (expression1)
{
  // Executes if expression1 is true.
}
else if (expression2)
{
  // Executes if expression1 is false and expression2 is true.
}
else
{
  // Executes if all expressions are false.
}
```

- c# exit the `if`-`else-if`-`else` block once one of the blocks is true so if the `if` block is `true` c# will ignore the other blocks of `else` and `else-if` for example:

  ```c#
  int myAge = 22;
  if (myAge >= 18) // true
  {
    WriteLine("go to university"); // this will only be excuted
  }
  else if (myAge >= 6) //true
  {
    WriteLine("go to school"); // this will be ignore considering the first one is true
  }
  else
  {
    WriteLine("go to kindergarden");
  }
  ```

- you can also make multiple condtion via the logical operator discussed earlier like the following

  ```c#
  bool isOk = true;
  bool isNotOk = false;
  if (isOk && !isNotOk)  
  {
      WriteLine("heeyyy");
  }
  ```

- you can also make nested `if` statements

  ```c#
  if (myAge >= 18) 
  {
    WriteLine("go to university, which one? 1.cairo 2.Nothing");
    int myChoice = 1; 
    if (myChoice ==  int.Parse(ReadLine()??"0"))
      {
          WriteLine("cairo");
      }
      else
      {
          WriteLine("Nothing???????????");
      }
  }
  ```

## special important notes

### return gaurds

- `if` support return gaurds so when you type a function and check for something instead of writing

```C#
public string GetStatus(int score)
{
  if (score >= 50)
  {
    return "Pass";
  }
  else
  {
    return "Fail";
  }
}
```

- you will only write

```c#
public string GetStatus(int score)
{
  if (score < 50)
  {
    return "Fail";
  }
return "Pass";
}
```

- The early return or guard clauses technique avoids deeply nested code in if statements by returning from a method as soon as a condition is met (or not met), rather than wrapping the main logic in an else block.

### ternary operator (one line `if`)

- it is the single shorthand symbol in the language for conditionals `? :`.

- And this is its structure:

```c#
var resultOfOperation = condition/*(boolean_expresssion)*/ ? value_if_true : value_if_false;
```

- it's short for

```c#
if (condition)
  resultOfOperation = value_if_true;
else
  resultOfOperation = value_if_false
```

- better not use the one line if statement and use the ternery operator instead as the former or the first may cause bugs

### pattern matching

- The `if` statement can use the `is` keyword in combination with declaring a local variable to make your code safer. It is important to note that a single expression, `o is int i`, does two things:
  - ***Checks the type*** of the data in a variable named o.
  - If the type check is `true`, then ***it assigns the value to the variable named i***.

  > an example of using it is the following
  >
  > ```C#
  >   // Add and remove the "" to change between string and int.
  > object o = "3";
  > int j = 4;
  > if (o is int i)
  > {
  >     WriteLine($"{i} x {j} = {i * j}");
  > }
  > else
  > {
  >     WriteLine("o is not an int so it cannot multiply!");
  > }
  > ```
