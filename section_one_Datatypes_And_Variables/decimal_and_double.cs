#:property PublishAot=false
using static System.Console;
WriteLine("here is the double");
#region double variables
// int myIntegerNumber = 323.40; // implicit conversion do not exist from double to int
double myDoubleNumber = double.Parse(ReadLine() ?? "0");
WriteLine(myDoubleNumber);
#endregion
#region decimel
WriteLine("here is the decimel");
decimal myDecimalNumber= decimal.Parse(ReadLine() ?? "0");
WriteLine(myDecimalNumber);
#endregion
#region double vs decimel
WriteLine("here is the double vs decimel");
double myAnotherDoubleNumber = double.Parse(ReadLine() ?? "0");
WriteLine($$"""
    when adding {{nameof(myDoubleNumber)}} : {{myDoubleNumber}} and {{nameof(myAnotherDoubleNumber)}} : {{myAnotherDoubleNumber}} 
    this will result in a weird unexpected result {{myDoubleNumber + myAnotherDoubleNumber}}
 """);

#endregion