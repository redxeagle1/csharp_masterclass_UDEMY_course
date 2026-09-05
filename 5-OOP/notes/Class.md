# classes

- classes composes of multiple elements

## `Constructor`

- which is a method that have the same name of the class itself and does not have a `return` method
    it's called whenever a new object is created from that class

    >**Car.cs**
    >
    >```Csharp
    >internal class Car
    >{
    >    static int count = 0;
    >    public Car()
    >    {
    >        count++;
    >        WriteLine($"an object of the class {nameof(Car)} is created now you have {count}");
    >    }
    >}
    >```
    >
    >**Program.cs**
    >
    > ```Csharp
    >class Program
    >{
    >    static void Main(string[] args)
    >    {
    >        WriteLine("Hello, World!");
    >        Car car1 = new();
    >        Car car2 = new();
    >        Car car3 = new();
    >        Car car4 = new();
    >        Car car5 = new();
    >    }
    >}
    > ```
    >
    > **Output**
    >
    > ```text
    > Hello, World!
    > an object of the class Car is created now you have 1
    > an object of the class Car is created now you have 2
    > an object of the class Car is created now you have 3
    > an object of the class Car is created now you have 4
    > an object of the class Car is created now you have 5
    > ```

### customizing the constructor

- we can customize the constructor of our class to perform set of actions like storing a user name and giving it an ID or create a car object from the `car` class with the  model "Hunyadi"

    > **Car.cs**
    >
    > ```Csharp
    > internal class Car
    > {
    >     private string _model;
    >     private string _name;
    >     public Car(string model, string name)
    >     {
    >         _model = model;
    >         _name = name;
    >         WriteLine($"the model of the assigned car is {_model} and the owner's name is {_name}");    
    >     }
    > }
    > ```
    >
    > **Program.cs**
    >
    > ```Csharp
    >     static void Main(string[] args)
    >     {
    >         Car hunyadi = new("Hunyadi","jeff");
    >         Car BMW = new("BMW","sine");
    >     }
    > ```

### multiple constructors

- you can override your default constructor with multiple constructor

    ```Csharp
    internal class Customers
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }

        //Custom Constructor
        public Customers(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public Customers(string name)
        {
            Name = name;
        }
    }
    ```

### Default Constructor

- when create your object without passing argument that way you are using the default constructor
- a benefit of the default constructor that you can set default properties for your object
- you can override the default constructor too!

    ```Csharp
    internal class Customers
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }

        // default constructor
        public Customers()
        {     
            Name = "New Customer";
            Address = "Unknown";
            ContactNumber = "None";
        }
    }
    ```

## member variable aka fields

fields have the following description

- fields are variables created outside of methods but inside a class
- they have a a class-level scoping which means any method can use it and access it
- they are called also **instance variable** an also **members**
- in general OOP terms its called **attributes**
- it's a ***Best Practice*** to make members always private scopes as discussed in the next sub-section
- to make them in top-level programs you MUST use partial members just like methods as the following of course
  
    > ```Csharp
    > public partial class Program
    > {
    >     static int number = 67;
    > }
    > ```
    >
    > `static` must be use to avoid instancing the variable and compiler error as will

- they are not considered as **global variables** since these are accessible through the project itself

### fields' naming conventions

- here is a summary table for the basic rules

| Field Type         | acceptable `Access` Modifier | Casing     | Prefix | Example           |
| ------------------ | ---------------------------- | ---------- | ------ | ----------------- |
| **Instance Field** | `private` / `internal`       | camelCase  | `_`    | `_userRepository` |
| **Static Field**   | `private` / `internal`       | camelCase  | `s_`   | `s_globalCounter` |
| **Thread Static**  | `private` / `internal`       | camelCase  | `t_`   | `t_localCache`    |
| **Constant**       | Any modifier                 | PascalCase | *None* | `MaxItemsPerPage` |
| **Public Field**   | `public` / `protected`       | PascalCase | *None* | `DefaultSettings` |

 according to official runtime rules to clearly denote that the field is static and shared across threads.(Note: Some teams omit the s and simply use a standard underscore *staticField, but s* is the recommended .NET standard).s_cacheRoots_defaultTimeout
> **Private Static Fields**
>
> - Use camelCase prefixed with `s_` `(s_staticField)`
>

### field vs local variable

- both are considered variable and all the rules of variables are applied to both
- local variable are defined at the method-level and the default in top-level programs
- fields are class-level accessible and called **instance variable**

## Properties [the setters and getters of Csharp]

- we knew how to initialize member in Csharp but alas we don't current have a method to control its value this is when properties comes handy which allow us to access members aka fields and manipulate it
- we can't as we mentioned use members or fields publicly instead we must use it privately and doing so will prevent other classes from accessing and manipulating our value including the `Main` method so we depend on properties for this sole purpose
- using the snippet we can easily define our properties with `prop`

  - **Properties in action**

    ```Csharp
    internal class Car
    {
        // fields
        private string? _model;
        private string? _name;
        // properties
        public string Model { get => _model ?? "undefined"; set => _model = value; }
        public string Name { get => _name ?? "undefined"; set => _name = value; }

        public Car(string model, string name)
        {
            // notice how we now can easily access and mutate our fields
            Model = model;
            Name = name;
        }
    }
    ```

    > Notice that used the `value` keyword to represent user submitted value
    > and this is considered the standard template generated by the snippet
    > the `=>` used denotes that this is a lambda expression

    ```Csharp
    // IN Program.cs 
    static void Main(string[] args)
    {
        Car Hunyadi = new("Hunyadi","jeff");
        Hunyadi.Model = "Hunyadi the indy";
        WriteLine(Hunyadi.Model); // Output : Hunyadi the indy
    }
    ```

### manipulating the property's set

- supposing that you want to preprocess value before passing it the field you can do so by turning the `set` part from lambda expression `set => _field = value;` into code block `set { _field = value; }` and take the next thing as an example

  - **Car.cs**

    ```Csharp
    internal class Car
    {
        // fields
        private string? _model;
        private string? _name;
        // properties
        public string Model
        { 
            get => _model ?? "Undefined";
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _model = value;
                }
                else
                {
                    WriteLine("field to process your input\r\nthe model has been set to \"Undefined\" as a fallback ");
                    _model = "Undefined";
                }
            } 
        }
    }
    ```
  
  > Notice how we made our set a code block

  - **Program.cs**

    ```Csharp
    Car BMW = new("BMW","sine");
    BMW.Model = null ;
    WriteLine(BMW.Model);
    /* output:
        >>> field to process your input
        >>> the model has been set to "Undefined" as a fallback 
        >>> Undefined
    */
    ```

### manipulating the property's get

- same as we did in the last sub-section we can manipulate the default get to perform more functionalities like returning a message based on the given data or a hash of something etc
- an example of that is

    ```Csharp
    internal class Car
    {
        // fields
        private string? _brand;
        private bool _isLuxury;

        // properties
        public string Brand
        {
            get
            {
                if (_isLuxury)
                {
                    return (_brand ?? "Undefined") + " - Luxury Edition";
                }
                else
                {
                    return _brand ?? "Undefined";
                }
            }
        }
    }

    // MAIN
    Car audi = new("A3" , "Audi", false);
    Car bmw = new("i7", "BMW", true);

    // GETTING BRAND
    WriteLine("Brand is " +  audi.Brand);
    WriteLine("Brand is " + bmw.Brand);
    ```

### backing field and `field` keyword

- a backing field is field needed when you want to process a value before `set` or `get` it but sometime we don't really need processing we just need to pass the value so why using a field if that is our sole purpose we can do that by performing the following

    ```Csharp
    class Car
    {
        // using a backing field for just storing our data only
        private int _number;
        public int Number { get => _number; set => _number = value; }
        
        // using the default property
        public  bool IsLuxury { get; set; }
    }
    ```

- you can also [after Csharp 14] use `field` keyword as way to avoid using backing field if you want to process a field in one property knowing that the `field` is scoped to only the property you currently using as the following example

  - **Before Csharp 14**

    ```Csharp
    internal class Car
    {
        private string? _brand;
        public  bool IsLuxury { get; set; }
        
        public string Brand
        {

            get => _brand ?? "Undefined" + (IsLuxury ? " - Luxury Edition" : ""  );
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    WriteLine("You entered NOTHING!");
                    _brand = "Undefined";
                }
                else
                {
                    _brand = value;
                }
            }

        }
    }
    ```

  - **After Csharp 14**

    ```Csharp
    internal class Car
    {
        public  bool IsLuxury { get; set; }

        public string Brand
        {

            get => field ?? "Undefined" + (IsLuxury ? " - Luxury Edition" : ""  );
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    WriteLine("You entered NOTHING!");
                    field = "Undefined";
                }
                else
                {
                    field = value;
                }
            }

        }
    }
    ```

### `init` keyword

- if you wanted an immutable (read-only) property either use
  - a constructor and give up the `set` entirely
  - make the `set` private

- the sole purpose of the `init` is to make your property read-only as the following

    ```Csharp
    public class Person
    {
        public string Name { get; init; } // Init-only
    }

    // Usage (Object Initializer):
    var p = new("Alice");   // This works!

    p.Name = "Bob";     // Compile Error! It is now locked.
    ```

## Methods

- A method is simply put is a function inside a class that allow us to perform action with our object
- While Csharp treats method as the default naming convention for the functions and name any function defined inside a method a `local function` most programming language name `functions` function outside classes while naming them `Method` inside classes or in the context of OOP in general
- A method is defined the same way of defining typical one in a Top-level program which is `<access_modifier> <function_name>(parameter list){function body}`
- Each object or class instance can use the same method with entirely different behavior

### Expression Bodied Members

- A form that replaces the standard code block way into more compact and readable expression or statement to certain class members which will be covered in this section
- An Expression Bodied Member is a shorthand syntax in Csharp that allows defining simple methods, properties, or even constructors using the lambda arrow (`=>`) instead of curly braces `{ }`
- The compiler then under the hood turn Expression Bodied member into full code block in the optimization phase
- **An Analogy for that** is rather than typing full 5-line paragraph just to declare a meeting only type *"Meeting at 5 PM."*

#### Declaring  and Using Expression Bodied Members

1. Methods

   - rather than typing a method like that

   ```Csharp
    class MathOperations
    {
        public int Square(int number)
        {
            return number * number;
        }
    }
   ```

   - we can just type

    ```Csharp
    class MathOperations
    {
        public int Square(int number) => number * number;
    }
    ```

2. Properties

    - rather than this

    ```Csharp
    class Person
    {
        private string name;
    
        public Person(string name)
        {
            this.name = name;
        }
    
        public string Name
        {
            get { return name; }
        }
    }
    ```

    - make this

    ```Csharp
    class Person
    {
        //field
        private string name;    
        
        //property
        public string Name => name;

        //constructor
        public Person(string name)
        {
            this.name = name;
        }
    }
    ```

3. Constructors

    - rather than this

    ```Csharp
    class Logger
    {
        private string message;
    
        public Logger(string msg)
        {
            message = msg;
        }
    }
    ```

    - make this

    ```Csharp
    class Logger
    {
        private string message;
    
        public Logger(string msg) => message = msg;
    }
    ```

4. Finalizers

    - rather than this

    ```Csharp
    class FileHandler
    {
        ~FileHandler()
        {
            Console.WriteLine("Finalizer called!");
        }
    }
    ```

    - make this

    ```Csharp
    class FileHandler
    {
        ~FileHandler() => Console.WriteLine("Finalizer called!");
    }
    ```

5. Indexers

- Indexers allow objects to be indexed like arrays. Expression Bodied Members make indexers shorter when they contain a single return statement.

  - Without Expression Bodied Syntax:

    ```Csharp
    class Collection
    {
        private int[] numbers = { 1, 2, 3, 4, 5 };
    
        public int this[int index]
        {
            get { return numbers[index]; }
        }
    }
    ```

  - With Expression Bodied Syntax:

    ```Csharp
    class Collection
    {
        private int[] numbers = { 1, 2, 3, 4, 5 };
    
        public int this[int index] => numbers[index];
    }
    ```

#### Best Practices and Common Mistakes

- Use Expression Bodied syntax for simple operations.
- Keep code concise but still readable.
- Use it in conjunction with standard methods when necessary.

- DON'T USE IT in the following
  - **Using it for complex logic** – If a method has multiple lines of code, stick to regular methods

## Inner Classes

- An Inner Class (also known as a nested class) is a class that is declared inside another class. This means that an inner class exists within the scope of an outer class. It can be useful when a class is only relevant within the context of another class.

  - how to declare it and use it

  ```Csharp
    using System;
    public class OuterClass
    {
        private string outerField = "I am from OuterClass";
    
        public class InnerClass
        {
            public void DisplayMessage()
            {
                Console.WriteLine("Hello from InnerClass");
            }
        }
    }
    
    class Program
    {
        static void Main()
        {
            // Creating an instance of the inner class
            OuterClass.InnerClass innerObject = new OuterClass.InnerClass();
            innerObject.DisplayMessage();
        }
    }
  ```

- An inner class can access members of the outer class if they are marked as public or protected, or if it has a reference to the outer class.

### when to Use Inner Classes?

- Encapsulation: Inner classes help group related logic together, improving readability and maintainability.
- Restricting Scope: If a class is only meant to be used inside another class, it makes sense to keep it enclosed.
- Better Organization: When a class is tightly coupled to another class, defining it as an inner class can improve code structure.

### Inner Classes vs

- Regular Classes:
  - **Inner Class Compared To Regular Class Are Scope Limited** to its outer class Available throughout the project
    - Higher Encapsulation Lower Readability
    - Better for related classes Can be scattered Access to Outer Class Yes, if referenced No

- Static Nested Classes
  - Inner classes should not be confused with static nested classes. A static nested class does not require an instance of the outer class.

    ```Csharp
    public class OuterClass
    {
        public static class StaticNestedClass
        {
            public static void ShowMessage()
            {
                Console.WriteLine("Hello from Static Nested Class");
            }
        }
    }
    
    class Program
    {
        static void Main()
        {
            OuterClass.StaticNestedClass.ShowMessage();
        }
    }
    ```

### Best Practices and Common Mistakes <!-- markdownlint-disable-line MD024 -->

- Best Practices
  - Use inner classes only when they are strongly related to the outer class.
  - Keep inner classes private unless external access is necessary.
  - Use static inner classes if they don’t require an outer instance.
  - Ensure clean separation of responsibilities.

- Common Mistakes
  - Overusing inner classes: If a class can exist independently, it should not be an inner class.
  - Accessing outer class members incorrectly: Use a reference to the outer class when accessing private members.
  - Ignoring encapsulation: Avoid exposing inner class functionality unless required.

## operator overloading

- it wouldn't be OOP if not using this functionality of c# instead of defining a method for adding it would be more convenient to overload the defined operators to create a new type of action
- for example adding vectors together will be adding each coordinate i.e. (x, y) together without creating a new method and call it
- we can that allows us to define custom behaviors for standard operators (`+`, `-`, `*`, `/`, `==`, etc.) when applied to user-defined types aka like structs or classes.
- a practical example for that is the following

    ```cs
    public class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }
    
        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }
        public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y);
    }

    }
    //////////////////////
    Vector result = v1 + v2;
    result.Display(); // Output: Vector: (10, 7)
    ```

### Best Practices <!-- markdownlint-disable-line MD000 -->

- Overload operators only when it improves code readability and maintainability.
- Always overload the corresponding opposite operator (e.g., if you overload ==, also overload !=).
- Keep operator implementations efficient and meaningful.
- Use value types (structs) wisely when overloading to avoid unnecessary heap allocations.
