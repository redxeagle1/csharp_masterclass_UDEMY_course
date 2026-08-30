using System;

namespace HelloClass;

internal class Car
{
    static int count = 0;
    public Car()
    {
        count++;
        WriteLine($"an object of the class {nameof(Car)} is created now you have {count}");
    }
}
