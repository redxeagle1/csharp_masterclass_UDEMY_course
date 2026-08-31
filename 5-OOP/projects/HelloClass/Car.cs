using System;

namespace HelloClass;

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
        Model = model;
        Name = name;
        WriteLine($"the model of the assigned car is {Model} and the owner's name is {Name}");    
    }
}
