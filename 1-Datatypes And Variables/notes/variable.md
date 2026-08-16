## variables <!-- markdownlint-disable-line MD041 -->

- it's a way to store data temporarly inside it think of it as box
- **Declaration and Assignment:** You can declare a variable to specify the type of data it will hold and allocate memory for it, then assign a value to it later.
- **Overwriting:** A variable's value can be overwritten or reassigned dynamically after its initial assignment.
- **Initialization:** You can combine declaration and assignment into a single step, known as initialization.

```csharp
// Declaring and assigning separately
string myVar; 
myVar = "saad"; 

// Overwriting the variable's value
myVar = "hindi man";

// Initialization (declaring and assigning at once)
string mySecondVar = "hamada hadawy";

```

### implicit and explicit typed variables

- explicit typed variable is defining the vaiable's type explicitly i.e. `int a = 3`
- implicit typed variable is defining the vaiable's type based on the given value if it's a `""` then the type is string and it's done by using the `var` keyword and it's only recommended when the variable type is clear like if you see integer number then it's and integer...etc and a usage example is

```c#
var myNumber = 67;
```

- hovering on the name or printing the type of the variable will tell you it's an integer

### scope of the variables

- the scope of the variable is defined based on the definatoin place wether it's a file-based scope, block-based i.e. in (`if` `for`), class-based scoping or functions
- the scope define the life cycle of the variable for example if a variable is defined inside an `if` block upon exiting that block it will delete the variable by the gorbage collector
- you cannot access a variable outside its scope
