## Reserved Characters <!-- markdownlint-disable-line MD041 -->

- these are symbols that affect the code, but not in the same way operations or operators manipulate data and return a value
- their main purpose is to define the structure of your code, the scope, and to group a set of commands or statements into different code blocks
- some of the most prominent categories under it are:

### pure structural punctuation

- the semi-colon or `;` : this determines the end of the statement itself
- the brackets family:
  - the parentheses or `()` : used in calling methods, passing arguments, defining expressions (optional), defining conditions, and performing casting operations
  - the brackets or `[]` : used to access items in arrays and collections, along with attributes
  - the braces, curly brackets or `{}` : used to define the start and end of a code block (whether in a function or control flow), as well as the initialization of objects and collections
  - the angle brackets or `<>` : used in generics, and dealing with HTML and XML. as standalone symbols, they act as greater than or less than operators
- the separator or comma `,` : used to separate elements in a list, like separating elements in collections, separating arguments, and separating variables when declaring them

### member and scope navigation

- the `.` sign : used to perform member access
- the `:` sign : used for inheritance or interfaces
- the `::` sign : acts as a namespace alias qualifier

### string literals

- these define the start and end of a text literal and the most important signs are:
  - the `'` or character literal boundary : defines just a single character
  - the `"` or string literal boundary : defines the start and end of a string variable
  - the `"""` or raw string boundary : wraps a string block and completely ignores any special characters or escape characters

### string and identifier modifiers

- the interpolation activator or `$` : enables you to inject values and variables directly inside your string
- the verbatim activator or `@` : allows you to do two things:
  - if placed before string literals, it completely ignores any escape characters
  - if placed before keywords, it allows you to use them as standard variables (identifiers)

### compilation and meta-directives

- the single-line comment marker or `//`
- the multi-line comment marker or `/**/`
- the preprocessor directive prefix or `#` : like `#if`

### operators

1. **Arithmetic Operations**: `+`, `-`, `*`, `/`, `%`, `++`, `--`
2. **Comparison and Logic**: `==`, `!=`, `>`, `<`, `&&`, `||`, `!`
3. **Null-Safety**: `??`, `??=`, `?.`
4. **Type-testing and Casting**: `is`, `as`, `typeof`, `sizeof`
5. **Lambda operator**: `=>`

- operators are actually categorized into 5 main categories based on the funcitonality
