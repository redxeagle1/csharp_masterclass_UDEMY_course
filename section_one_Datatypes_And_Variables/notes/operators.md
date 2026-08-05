# operators and expressions

* **Operand**: The number or value on which the mathematical operation is performed.
* **Operator**: The symbol that determines the type of the operation (e.g., `÷`, `×`, `-`, `+`).

And this is their general format:

```c#
// Operation form
firstOperand operator secondOperand;

```

This composition forms an **expression**.
While this is the standard order, in programming, we classify operators into 3 types based on their placement:

## unary operator

Its format looks like this:

```c#
var resultOfOperationAfter = onlyOperand operator;
var resultOfOperationBefore = operator onlyOperand;

```

And here is an example of its usage:

```c#
int a = x++; //some;

```

Operators that follow this format are:

* `++` , `--`: Increment and decrement by 1, respectively.
* `typeof(int)`: To find out the data type.
* `sizeof(int)`: To find out the size in Bytes.
* `nameof(x)`: To get the variable name as a String.
* `!isTrue`: For logical negation `!`.
* The `-` or minus sign to make a number negative, like `-1`.

> Quick note:
> The `++` and `--` signs are a bit special because they can work after the operand (postfix) or before it (prefix). This makes a difference in the assignment process, and you'll notice it more when making loops.

This is postfix (after):

```c#
int a = 3;
int b = a++;
WriteLine($"a is {a}, b is {b}"); //>>> a is 4, b is 3

```

And this is prefix (before):

```c#
int c = 3;
int d = ++c;
WriteLine($"c is {c}, d is {d}"); // c is 4, d is 4

```

## binary operator

Works on 2 Operands (which is the most common).

* **Example**: `price + 10` or `x > 5`.

And this is its template:

```c#
var resultOfOperation = firstOperand operator secondOperand;

```

## ternary operator

Works on 3 Operands (and it is a single shorthand symbol in the language for conditionals `? :`).

* **Example**: `isAdult ? "Yes" : "No"`

And this is its template:

```c#
var resultOfOperation = firstOperand "firstOperator" secondOperand "secondOperator" thirdOperand;

```

## order of evaluation

* in arthmatic perspective you can memorise the thing eadily with `BEDMAS` short for
  1. `bracket`
  2. `Exponentional`
  3. `Division`
  4. `Multiplication`
  5. `Additoin`
  6. `Subtraction`

| Symbol 1                                                           | Type of operation                | Associativity |
| ------------------------------------------------------------------ | -------------------------------- | ------------- |
| `[` `]` `(` `)` `.` `->`  `++` `--` (postfix)                      | Expression                       | Left to right |
| **`sizeof`** `&` `*` `+` `-` `~` `!`  `++` `--` (prefix)           | Unary                            | Right to left |
| _typecasts_                                                        | Unary                            | Right to left |
| `*` `/` `%`                                                        | Multiplicative                   | Left to right |
| `+` `-`                                                            | Additive                         | Left to right |
| `<<` `>>`                                                          | Bitwise shift                    | Left to right |
| `<` `>` `<=` `>=`                                                  | Relational                       | Left to right |
| `==` `!=`                                                          | Equality                         | Left to right |
| `&`                                                                | Bitwise-AND                      | Left to right |
| `^`                                                                | Bitwise-exclusive-OR             | Left to right |
| `\|`                                                               | Bitwise-inclusive-OR             | Left to right |
| `&&`                                                               | Logical-AND                      | Left to right |
| `\|`                                                               | Logical-OR                       | Left to right |
| `? :`                                                              | Conditional-expression           | Right to left |
| `=` `*=` `/=` `%=`  `+=` `-=` `<<=` `>>=` `&=`  `^=` `\|=`         | Simple and compound assignment 2 | Right to left |
| `,`                                                                | Sequential evaluation            | Left to right |

## operator categories

> Of course, it is worth noting that operators are actually categorized into 5 main categories, which are:

1. **Arithmetic Operations**: `+`, `-`, `*`, `/`, `%`, `++`, `--`
2. **Comparison and Logic**: `==`, `!=`, `>`, `<`, `&&`, `||`, `!`
3. **Null-Safety**: `??`, `??=`, `?.`
4. **Type-testing and Casting**: `is`, `as`, `typeof`, `sizeof`
5. **Lambda operator**: `=>`
