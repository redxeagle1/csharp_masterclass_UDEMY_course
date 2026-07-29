#:property PublishAot=false
using static System.Console;
#region integers
int mynum = 3233;

WriteLine($"""
    my number = {mynum} 
    it's bigger than {int.MinValue} 
    less than {int.MaxValue}
    the default integer value is {default(int)}
    """);
#endregion

#region getting input and store it in a number [parsing basics]
WriteLine("enter something to start parsing");
int myinputnumber = int.Parse(ReadLine() ?? "0");
#endregion

