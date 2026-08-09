# loop types

- you can delay the execution of your app using  `Thread.Sleep(TIME_IN_MILLESECONDS);` which will delay the execution for 1sec and continue it and it must be used outside the production environment

## for loop

- repeat for a specific number of times
- it compose of 3 part
  - initialization : where you assign a predefined variable a start value or you to initialize a new one
  - condition : where you set the condition on which the loop ends on it
  - iterator : the factor in which the loop will iterate on weather it's increamneting a the variable's value or decrament it
- you can stop the loop entirely using the `break` keyword
- you can ignore an iteration using the `continue` keyword

```c#
for (initialization; condition; iterator)
{
    // Code to execute on each iteration
    if (something)
    {
        continue; // to ignore this iteration
    }
    break; // to stop the code
}
```

- A code example of it is

```c#
for (int i = 0; i < 10; i++)
{
    WriteLine($"counting now {i}");
}
```

- while loops

```c#
while (true)
{
    
}
```

- do while loops

```c#
do
{
    
} while (true);
```

- foreach loops

```c#
foreach (var item in collection)
{
    
}
```
