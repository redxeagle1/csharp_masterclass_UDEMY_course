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

- **string are array** of `char` element meaning you can manipulate them as if you are manipulating `array` such accessing a letter through it's index like `string[0]`
- **String Literals:** Variables declared with the `string` type only hold text (string literals).
- **Concatenation:** You can join strings together or with other data types (like integers) using the `+` operator. Formatting characters like `\t` can be injected for spacing.
- **String Interpolation:** Prefixing a string with `$` allows you to embed variables and expressions directly inside curly braces `{}`. This is often cleaner and more readable than standard concatenation.
- **string formating** it's a form of interpolation and can be done in 2 methods and it can use Format Specifiers to further customize the variable placement you can check what you will be able to through [this link](https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings)
  1. using `.formate` funciton

     > ```c#
     > string name = "Alice";
     > int age = 30;
     > string result1 = string.Format("Name: {0}, Age: {1}", name, age);
     > // here as a format specifier example
     > string rightAligned = string.Format("|{0,10}|", "Apple");
     > ```

  2. using through the `WriteLine` args

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

### escape characters

- there special set of characters in strings called calles escape character these are always prefixed with a backslash `\` example of that is
  - when you try to write a `"` inside a string you will get an error to prefix it with a `\` like that `\"`
  - when you try to write a `\` inside a string you will get an error to prefix it with a `\` like that `\\`
- if you really don't want to use this entirely you should use verbitam string which are special types of strings that can take the escape character with the need of `\` or escpaing it an example of this section is
- `\n` which is a `newline` is a unix based thing it's better to use the carrage return or `\r`

```c#
// string myNeatVar = "eh, sam said "am a very irogent man""; this is a clear error
string myNeatVar = "eh, sam said \"am a very irogent man\"";  // this is escaping
myNeatVar = @"eh, sam said \' irogent man"; 
```

### string operation

- string does have built-in funcitons to manipulate it here some of them

- `string.Trim()`: remove all the white speces form the end `string.TrimEnd()` and from the begining `string.TrimStart()`
  - for exmple if we have `"        jwk         "` => `"jwk"`

- `string.ToLower()`: turn all the letters of a string to lower case and it's contradiction method is `string.ToUpper()`

> you can chaing function i.e. `string.Trim().ToLower()`

- `string.Length`: print our the lenght of the string
