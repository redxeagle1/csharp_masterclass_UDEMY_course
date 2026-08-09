#:property PublishAot=false
using static System.Console;
#region impilict casting
int a = 123432;
double b = a ;
#endregion
#region expilicit casting
long myLong = 232412324112131320;
int myMaxInt = int.MaxValue;
int myCastedInt = (int) myLong;
WriteLine(myMaxInt);
WriteLine(myCastedInt);
#endregion
#region non-excplicit conversion
string? random_input = ReadLine();
// int valid_number = int.Parse(random_input?? "0");  // no eception handling
// you can handle the exception through tryparse

// Declaring the out variable inside the method call (C# 7.0+)
if (int.TryParse(random_input, out int result))
{
   WriteLine($"Success! The number is {result}");
}
//

try
{
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    string baba = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
    int one_b = Convert.ToInt32(baba);
    WriteLine(one_b);
}
catch (Exception e)
{
    WriteLine($"{e.Message}\nhamada is dead");
}
#endregion
ReadKey();