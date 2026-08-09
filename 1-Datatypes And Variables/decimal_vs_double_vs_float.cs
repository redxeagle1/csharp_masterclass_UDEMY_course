#:property PublishAot=false
using static System.Console;
WriteLine("here is the double");
#region double variables
// int myIntegerNumber = 323.40; // implicit conversion do not exist from double to int
double myDoubleNumber = double.Parse(ReadLine() ?? "0");
WriteLine(myDoubleNumber);
#endregion
#region decimal
WriteLine("here is the decimal");
decimal myDecimalNumber= decimal.Parse(ReadLine() ?? "0");
WriteLine(myDecimalNumber);
#endregion
#region double vs decimal
WriteLine("\n\n\n\n\nhere is the double vs decimal");
WriteLine("enter 2 diferrent numbers");
double myAnotherDoubleNumber = 13.9;
myDoubleNumber = 15.3;
WriteLine($$"""
    when adding {{nameof(myDoubleNumber)}} : {{myDoubleNumber}} and {{nameof(myAnotherDoubleNumber)}} : {{myAnotherDoubleNumber}} 
    this will result in a weird unexpected result {{myDoubleNumber + myAnotherDoubleNumber}}
    instead of {{29.2}}
    """);
// because of the way floating-point numbers are represented in th the computer memory in binary format flowing an IEEE standerd

// to solve this you can do
/// 1. using decimal
myDecimalNumber =  13.9M;
decimal myAnotherDecimalNumber = 15.3m ;
WriteLine($$"""
    when adding {{nameof(myDecimalNumber)}} : {{myDecimalNumber}} and {{nameof(myAnotherDecimalNumber)}} : {{myAnotherDecimalNumber}} 
    the result is {{myDecimalNumber + myAnotherDecimalNumber}}
    """); // due to using different way of representation
/// 2. using math.round 
WriteLine($$"""
    when adding {{nameof(myDoubleNumber)}} : {{myDoubleNumber}} and {{nameof(myAnotherDoubleNumber)}} : {{myAnotherDoubleNumber}} 
    the result is {{myDoubleNumber + myAnotherDoubleNumber}} and by rounding {{Math.Round(myDoubleNumber + myAnotherDoubleNumber,2)}}
    """);

WriteLine("\n\n\n\n\n not knowing this was The inaccuracy caused it to fail to track and intercept an incoming "+
"Iraqi Scud missile, and 28 soldiers were killed");
// link :- https://www-users.cse.umn.edu/~arnold/disasters/patriot.html.
// use double in everyday task but in equality use **decimal** 
#endregion

#region Float
WriteLine("here is the float");
float price = 19.99f;
WriteLine(price);
WriteLine(float.MaxValue);
WriteLine(float.NegativeInfinity);

#endregion
