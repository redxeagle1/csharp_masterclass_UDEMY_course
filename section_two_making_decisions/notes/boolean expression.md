## boolean expression <!-- markdownlint-disable-line -->

- boolean expressions are to evaluate the logical state of a decision wether it's `true` or `false`.
- boolean datatypes differ from the expresssion as the boolean datatypes hold either `true` or `false` only and considered the simplist truth value

> booleans are defined as the following
>
> ```c#
> bool isOk = true;
> ```
>

- the usage of boolean expression is connected with decisions and condition
- boolean expression can be categoriesed into
  - **logical operators**  : which utilized the power of `AND`, `OR`, `NOT` and `XOR` to create logical complex conditions which in the end evaluted to either `true` or `false`
  an example of that is `can I fly and can I drive a car` this is evaluated to `false`
    - `AND` : evaluate to `true` if and only of ***all the operands of it are `true`***
    - `OR` : evaluate to `true` if only ***one or all the operands are `true`***
    - `NOT` : reverse thr truth state if it's `true` then it will evaluate to `false`
    - `XOR` : evaluate to `true` if and only if ***one of the operands is `true` only***
  - **comparative operators** : using operators like `<` or `>` or `==` to build complex expressions
  - **compound expression** : mixing between the ogical operators and comparative operators

> unlike python, php or javascript the c# language doesn't have Implicit conversions from text/numbers to bool are forbidden. YOU MUST compare to get the `bool` value
