#:property PublishAot=false
using static System.Console;

#region double variables
// int myIntegerNumber = 323.40; // implicit conversion do not exist from double to int
double myDoubleNumber;
myDoubleNumber = double.Parse(ReadLine() ?? "0");
WriteLine(myDoubleNumber);
#endregion