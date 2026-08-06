## char datatype  <!-- markdownlint-disable-line MD041 -->

- a primitive datatype that stores only one character at a time inside a `''` mark
- it Represents a character as a UTF-16 code unit. which is 16-bit Unicode Transformation Format capable of representing 1,112,064 valid code points of Unicode.
- you can represent emojis as a char by it to
- example

```c#
char hamada = 's';
Writeline(hamada)
```

## string datatype

- **String Literals:** Variables declared with the `string` type only hold text (string literals).
- **Concatenation:** You can join strings together or with other data types (like integers) using the `+` operator. Formatting characters like `\t` can be injected for spacing.
- **String Interpolation:** Prefixing a string with `$` allows you to embed variables and expressions directly inside curly braces `{}`. This is often cleaner and more readable than standard concatenation.

> if you added `$$` you will have  to embed in double curly braces `{{}}` and if the `$` increases the `{` will increase respectively

```csharp
int myAge = 67;
string firstName = "saad";
string lastName = "ahmed";

// Concatenation
string myFullName = firstName + "\t" + lastName + "\t" + myAge; 
Console.WriteLine(myFullName); 

// String interpolation
Console.WriteLine($"hello {myFullName} I think you like {myAge}"); 
```
