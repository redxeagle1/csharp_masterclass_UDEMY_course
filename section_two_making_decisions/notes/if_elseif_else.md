# selection statements

- every application alogrithm need to make decisions such as identify if a user need to log in or not or if he has already an account
- the two primary selection statements are `if` and `switch`

## `if`

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

- you can also make multiple condtion via the logical operator discussed earlier like the following

```c#
bool isOk = true;
bool isNotOk = false;
if (isOk && !isNotOk)  
{
    WriteLine("heeyyy");
}
```

### special `if` notes

#### return gaurds

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

#### pattern matching

#### ternary operator (one line if)
