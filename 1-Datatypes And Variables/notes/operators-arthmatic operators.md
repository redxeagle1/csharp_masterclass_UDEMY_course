### arthmatic operation <!-- markdownlint-disable-line MD041 -->

* addition : `+` like $1 + 1 = 2$
* subtraction : `-` like $3 - 1 = 2$
* mulitplication : `*` like $2 \times 2 = 2$
* division : `/` like $\frac{6}{2} = 3$
* modulus (remember) : `%` it retruns thereminder of the division ($10 \bmod 3 = 1$) useful in cases where you want to check the divisablity of a number
* assignment operator (compound assignment operator)
  * basicly it performs an operation on a variable and then assigns the result back to that same variable in a single, shorthand steps
  * the expressoin in general syntax is writen as the following

  ```c#
     x op= y is equivalent to x = x op y
  ```

* increment : `++` : Increases the variable's value by 1
* decrement : `--` : Decreases the variable's value by 1
  * `x++` means exactly $x = x + 1$
  > _**IMPORTANT NOTES**_
  >
  > Postfix (e.g., x++, x--)\
  > * **Use** the current value **first**, then **change** it.
  > * Example: If x = 5, then y = x++ results in y = 5 and x = 6.
  >  
  > Prefix (e.g., ++x, --x)
  > * **Change** the value **first**, then **use** it.
  > * Example: If x = 5, then y = ++x results in y = 6 and x = 6.
