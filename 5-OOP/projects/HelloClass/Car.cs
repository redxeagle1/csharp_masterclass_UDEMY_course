using System;

namespace HelloClass;

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
    public string Name
    {
        get => _name ?? "unknown";
        set => _name = value;
    }

    public Car(string model, string name)
    {
        Model = model;
        Name = name;
        WriteLine($"the model of the assigned car is {Model} and the owner's name is {Name}");
    }
}
