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

## foreach

- foreach loops

```c#
foreach (var item in collection)
{
    
}
```

## while loop

- while loops : repeat based on a condition and stops the moment it doesn't get satisfied
- you can understand it as `until` this condition is met `do` the following logic
- `While` checks the condition then execute
  - you can use it as `for loop` which isn't conventient and can result in infinit loop
  - conditional which better use it for
- you can stop the loop entirely using the `break` keyword
- you can ignore an iteration using the `continue` keyword

```c#
while (condition)
{
    // block to execute 
}
```

> - there is a special form of `while` where it ***executes*** the code ***then checks*** the condition which is called `do-while` loop
> - do while loops>
>
> ```c#
> do
> {
>     
> } while (condition);
> ```
>
> - a clear example of its effect is when you print something for 10 times and this loop will print it 11 times aka 1 extra time of execution

## labeling

- looping through an explicit label and c# currently depends on the `goto` statement fot=r hat though it isn't a best practise or a good advice to do so since it's more error prone
- a basic goto example will be

```C#
int a = 0;
hamada:
WriteLine("what am I doing {0}",a);
if (a != 5){
    a++;
    goto hamada;
}
else
    WriteLine("ending the program");
```

> - in c# 15, c# will support Labelled break and continue statements and the ide it self will suggest you to use it instead of relaying on `goto` in `for`, `while` loops and in `switch` cases
> - an example of the code will be written is
>
> ```C#
> outerLoop: 
> for (int x = 0; x < xMax; x++) 
> {
>     for (int y = 0; y < yMax; y++) 
>     {
>         if (ShouldSkipRest(x, y)) 
>             continue outerLoop; // Skips to the next iteration of the outer loop
> 
>         if (ShouldExitAll(x, y)) 
>             break outerLoop; // Breaks completely out of the outer loop
>     }
> }
> ```
>
> I feel this feature is gonna be great one
