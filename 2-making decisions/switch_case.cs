#:property PublishAot=false
using static System.Console;

int day = 3;
/*
Create a simple C# program using a switch statement to replace an if-else structure for printing days of the week based on an integer value.
*/
switch (day)
{
    case 1:
        WriteLine("Monday");
        break;
    case 2:
        WriteLine("Tuesday");
        break;
    case 3:
        WriteLine("Wednesday");
        break;

    default:
        WriteLine("Another day");
        break;
}