using System;
using System.Reflection.Metadata;

namespace HelloClass;

internal class Car
{
    // member variable
    private int _number;


    // Property
    // With lambda expression
    public string Model { get => field ?? "Undefined" ; set; }

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
    public  bool IsLuxury { get; set; }
    public int Number { get => _number; set => _number = value; }


    // Custom Constructor
    public Car(string model, string brand, bool isLuxury)
    {
        Model = model;
        Brand = brand;
        Console.WriteLine($"A {Brand} of the" +
            $" model {Model} has been created");
        IsLuxury = isLuxury;
    }

    public void Drive()
    {
        WriteLine($"I'm {Model} I'm Driving");
    }
}