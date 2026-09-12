using System;
using Coding.Exercise;
// Create a simple C# program that declares a class with a private readonly 
// field and a public read-only property to access it. 
// The class should have a constructor that initializes the readonly field.
//  Create an instance of the class and print the value of the read-only property to the console.
namespace Coding.Exercise
{
    public class MyClass
    {
        // TODO: Declare a private readonly field to store the value
        private readonly string _secret;
        // TODO: Create a public read-only property to expose the field's value
        public string GetSecret {get=> _secret;} 
        public MyClass(string value)
        {
            // TODO: Initialize the readonly field with the value parameter
            _secret = value;
        }
    }

    public class Exercise
    {
        public void PrintReadOnlyProperty()
        {
            // TODO: Create an instance of MyClass with the value "Read-Only Property Value"

        }
    }
}

class Program
{
    static void Main()
    {
            MyClass thing = new("Read-Only Property Value");
            // TODO: Print the value of the read-only property to the console
            Console.WriteLine(thing.GetSecret);
    }
}