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

## member variable aka fields

fields have the following descritionp

- fields are variables created outside of methods but inside a class
- they have a a class-level scoping which means any method can use it and access it
- they are called also **instance variable** an also **members**
- in general OOP terms its called **attributes**
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

|Field Type|acceptable `Access` Modifier|Casing|Prefix|Example|
|---|---|---|---|---|
|**Instance Field**|`private` / `internal`|camelCase|`_`|`_userRepository`|
|**Static Field**|`private` / `internal`|camelCase|`s_`|`s_globalCounter`|
|**Thread Static**|`private` / `internal`|camelCase|`t_`|`t_localCache`|
|**Constant**|Any modifier|PascalCase|_None_|`MaxItemsPerPage`|
|**Public Field**|`public` / `protected`|PascalCase|_None_|`DefaultSettings`|

 according to official runtime rules to clearly denote that the field is static and shared across threads.(Note: Some teams omit the s and simply use a standard underscore _staticField, but s_ is the recommended .NET standard).s_cacheRoots_defaultTimeout
> **Private Static Fields**
>
> - Use camelCase prefixed with `s_` `(s_staticField)`

### field vs local variable

- both are considered variable and all the rules of variables are applied to both
- local variable are defined at the method-level and the default in top-level programs
- fields are class-level accessible and called **instance variable**
