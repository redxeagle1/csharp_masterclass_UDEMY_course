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

- **Strings** are a type of which can hold multiple series of charaters or in other words string litrals which is defined in `""`
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

### string array method

- `string` is an array in the end, an array of `char` elements
- The variables of type string have many built-in methods that convert a single string into either an array of smaller strings, or an array of individual characters.
- string are array of `char` element meaning you can manipulate them as if you are manipulating `array` such accessing a letter through it's index like `string[0]`

- you can turn a string into array of char using the `ToCharArray()` method as the following

  > ```c#
  > string value = "abc123";
  > char[] valueArray = value.ToCharArray();
  > ```
  >
  > - this will definatley helps you in performing normal array operation such as reverse ordering
  >
  > ```c#
  > Array.Reverse(valueArray);
  > string result = new string(valueArray); // 321cba
  > ```

- in case you make a `string` of an array and sperate each element with a sperator like a new line comma,...etc you can and should use - for performance optimization rather than manual iteratoin - `string.Join(string_seperator, array)`
  
  > ```C#
  > string[] fruits = { "Apple", "Banana", "Orange" };
  > Console.WriteLine(string.Join("\n", fruits));
  > /*
  > Apple
  > Banana
  > Orange
  > */
  > ```

- you can create a `string` type array from a string using the `.Split()` method as the following

  > ```C#
  > string value = "abc123";
  > char[] valueArray = value.ToCharArray(); // ['a', 'b', 'c', '1', '2', '3']
  > string result = String.Join(",", valueArray); // 3,2,1,c,b,a
  > string[] items = result.Split(','); // ["a", "b", "c", "1", "2", "3"]
  > ```

- you can know the index of a specific character's ***first occurance*** in a string by using `.IndexOf(ARRAY, 'c')` where c is a `char` argument

  > ```c#
  > string message = "Find what is (inside the parentheses)";
  > int openingPosition = message.IndexOf('('); // 12
  > // which you can then access it 
  > Console.WriteLine(message[openingPosition]); // (
  > ```
  >
  > - you can use `.LastIndexOf()` to get the index of the a specific character's ***last occurance***
  > - both of the methods will return `-1` if they didn't find any matchs

- if you want to get the indexes of multiple character at once you must use `IndexOfAny` which reports the index of the ***first occurrence of any character*** in a supplied **array of characters**. The method returns -1 if all characters in the array of characters are not found.

  > ```C#
  > string message = "Hello, world!";
  > char[] charsToFind = { 'a', 'e', 'i' };
  > 
  > int index = message.IndexOfAny(charsToFind);
  > 
  > Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}."); 
  > // output Found 'e' in 'Hello, world!' at index: 1.
  > ```

- you can slice or take a part of a string using the `.Substring(start_Index, length)` method

  > ```C#
  > string message = "Find what is (inside the parentheses)";
  > 
  > int openingPosition = message.IndexOf('(');
  > int closingPosition = message.IndexOf(')');
  > 
  > openingPosition += 1;
  > 
  > int length = closingPosition - openingPosition;
  > Console.WriteLine(message.Substring(openingPosition, length)); // Output : inside the parentheses
  > ```

- when there's a standard and consistent position of the characters you want to remove from the string. use `Remove()`

  > ```c#
  > string data = "12345John Smith          5000  3  ";
  > string updatedData = data.Remove(5, 20);
  > Console.WriteLine(updatedData); // output : 123455000  3  
  > ```

- The `Replace(string target, string replacement)` method is used when you need to ***replace one or more characters with a different character (or no character)***. The `Replace()` method is different from the other methods used so far, ***it replaces every instance of the given characters***, not just the first or last instance.

  > ```C#
  > string message = "This--is--ex-amp-le--da-ta";
  > message = message.Replace("--", " ");
  > message = message.Replace("-", "");
  > Console.WriteLine(message); // Output : This is example data
  > ```

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
