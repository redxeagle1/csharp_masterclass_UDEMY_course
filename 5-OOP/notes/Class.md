# classes

- classes composes of multiple elements

## a `constructor`

- which is a method that have the same name of the class itself and does not have a `return` method
    it's called whenever a new object is created from that class

    >**Car.cs**
    >
    >```c#
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
    > ```C#
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

- we can customize the constructor of our class to perform set of actions like storing a user name and giving it an ID or create a car object from the `car` class with the  model "hundai"

    > **Car.cs**
    >
    > ```c#
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
    > ```c#
    >     static void Main(string[] args)
    >     {
    >         Car hundai = new("hundai","jeff");
    >         Car BMW = new("BMW","sini");
    >     }
    > ```

### multiple constructors

- you can override your default constructor with multiple constructor

    ```c#
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
- yyou can override the default constructor too!

    ```c#
    internal class Customers
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }

        // default constructor
        public Customers()
        {     
            Name = "New Customer";
            Address = "Unkown";
            ContactNumber = "None";
        }
    }
    ```

## member variable aka fields

fields have the following descritionp

- fields are variables created outside of methods but inside a class
- they have a a class-level scoping which means any method can use it and access it
- they are called also **instance variable** an also **members**
- in general OOP terms its called **attributes**
- it's a ***Best Practise*** to make members always private scopes as discussed in the next sub-section
- to make them in top-level programs you MUST use partial members just like methods as the following of course
  
    > ```c#
    > public partial class Program
    > {
    >     static int number = 67;
    > }
    > ```
    >
    > `static` must be use to avoid instancing the variable and compiler error as will

- they are not considerd as **global variables** since these are accessible through the project itself

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

## Properties [the setters and getters of c#]

- we knew how to initilize member in c# but alas we don't current have a method to control its value this is when properties comes handy which allow us to acees members aka fields and manipulate it
- we can't as we mentioned use members or fields puplicly instead we must use it privately and doing so will prevent other classes from acessing and manipulaing our value including the `Main` method so we depend on properties for this sole perposs
- using the snippit we can eazily difine our properties with `prop`

  - **Propertise in action**

    ```c#
    internal class Car
    {
        // fields
        private string? _model;
        private string? _name;
        // probeties
        public string Model { get => _model ?? "undifiend"; set => _model = value; }
        public string Name { get => _name ?? "undifiend"; set => _name = value; }

        public Car(string model, string name)
        {
            // notice how we now can eazily access and mutate our fields
            Model = model;
            Name = name;
        }
    }
    ```

    > Notice that used the `value` keyword to represent user submitted value
    > and this is considered the standerd template generated by the snippit
    > the `=>` used denotes that this is a lamda expression

    ```c#
    // IN Program.cs 
    static void Main(string[] args)
    {
        Car hundai = new("hundai","jeff");
        hundai.Model = "hundai the indi";
        WriteLine(hundai.Model); // Output : hundai the indi
    }
    ```

### manipulating the property's set

- supposing that you want to preprocess value before passing it the field you can do so by turning the `set` part from lamda expression `set => _field = value;` into code block `set { _field = value; }` and take the next thing as an example

  - **Car.cs**

    ```c#
    internal class Car
    {
        // fields
        private string? _model;
        private string? _name;
        // probeties
        public string Model
        { 
            get => _model ?? "Undifined";
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _model = value;
                }
                else
                {
                    WriteLine("fiald to process your input\r\nthe model has been set to \"Undifined\" as a fallback ");
                    _model = "Undifined";
                }
            } 
        }
    }
    ```
  
  > Notice how we made our set a code block

  - **Program.cs**

    ```c#
    Car BMW = new("BMW","sini");
    BMW.Model = null ;
    WriteLine(BMW.Model);
    /* output:
        >>> fiald to process your input
        >>> the model has been set to "Undifined" as a fallback 
        >>> Undifined
    */
    ```

### manipulating the property's get

- same as we did in the last sub-section we can manipulate the default get to perform more functionalities like returning a message based on the given data or a hash of something etc
- an example of that is

    ```c#
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
                    return (_brand ?? "Undifiend") + " - Luxury Edition";
                }
                else
                {
                    return _brand ?? "Undifiend";
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

    ```c#
    class Car
    {
        // using a backing field for just storing our data only
        private int _number;
        public int Number { get => _number; set => _number = value; }
        
        // using the default proberty
        public  bool IsLuxury { get; set; }
    }
    ```

- you can also [after c# 14] use `field` keyword as way to avoid using backing field if you want to process a field in one proberty knowing that the `field` is scoped to only the property you currently using as the following example

  - **Before C# 14**

    ```c#
    internal class Car
    {
        private string? _brand;
        public  bool IsLuxury { get; set; }
        
        public string Brand
        {

            get => _brand ?? "Undifiend" + (IsLuxury ? " - Luxury Edition" : ""  );
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    WriteLine("You entered NOTHING!");
                    _brand = "Undifiend";
                }
                else
                {
                    _brand = value;
                }
            }

        }
    }
    ```

  - **After C# 14**

    ```c#
    internal class Car
    {
        public  bool IsLuxury { get; set; }

        public string Brand
        {

            get => field ?? "Undifiend" + (IsLuxury ? " - Luxury Edition" : ""  );
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    WriteLine("You entered NOTHING!");
                    field = "Undifiend";
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

    ```c#
    public class Person
    {
        public string Name { get; init; } // Init-only
    }

    // Usage (Object Initializer):
    var p = new("Alice");   // This works!

    p.Name = "Bob";     // Compile Error! It is now locked.
    ```
