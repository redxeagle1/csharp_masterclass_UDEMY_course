using System;

namespace HelloClass;

internal class Car
{
    private string _model;
    private string _name;
    public Car(string model, string name)
    {
        _model = model;
        _name = name;
        WriteLine($"the model of the assigned car is {_model} and the owner's name is {_name}");    
    }
}
