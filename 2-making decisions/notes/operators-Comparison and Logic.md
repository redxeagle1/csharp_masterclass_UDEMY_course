## relational operators or comparation operator <!-- markdownlint-disable-line MD041 -->

- Less than `<`
- Less or equal than `<=`
- Greater than `>`
- Greater or equal than `>=`
- Equal to `==`
- Not equal to `!=`

> all of them are binary operators meaning they perform in two operand

## logical operators

- although we mentioned that c# does have `AND`, `OR`, `NOT` and `XOR`  logical operators but c# doesn't express them literally instead it represent them in form or `&&`, `||`, `!` and  `^` respectively where used as mentioned earlier to make complex decision making

>- C# has the 3 sets these boolean operators.
>   - `&` `|` `!`: Boolean operators over bits
>   - `&&` `||` `!`: Boolean operators over bool
>   - `and` `or` `not`: Boolean operators over patterns matching

|Operator|Name|Description|Example (`bool a = true, b = false;`)|
|---|---|---|---|
|`&&`|Conditional AND|Returns `true` only if **both** operands are true. Shorts circuits.|`a && b` → `false`|
|`\|`|Conditional OR|Returns `true` if **at least one** operand is true. Short circuits.|`a \| b` → `true`|
|`!`|Logical NOT|**Inverts** the boolean value.|`!a` → `false`|
|`^`|Logical XOR|Returns `true` if **exactly one** operand is true, but not both.|`a ^ b` → `true`|
|`&`|Logical AND (No short-circuit)|Evaluates **both** sides, even if the left side is false.|`a & b` → `false`|
|`\|`|Logical OR (No short-circuit)|Evaluates **both** sides, even if the left side is true.|`a \| b` → `true`|

> Short-Circuiting : For `&&` as an example , if the first condition is false, the second condition is never evaluated because the overall result must be false.
