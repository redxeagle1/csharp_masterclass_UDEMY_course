# classes

- classes composes of multiple elements
  - a `constructor` which is a method that have the same name of the class itself and does not have a `return` method
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
