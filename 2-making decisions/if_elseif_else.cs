#:property PublishAot=false
using static System.Console;
/*
Your task is to create a simple C# program that checks whether a user is logged in using a boolean variable. 
If the user is logged in, the program should print "Welcome back!",
otherwise, it should print "Please log in."
*/
bool isLoggedIn = true;

// Assign a value to isLoggedIn based on user input or condition

if (isLoggedIn)
{
    WriteLine("Welcome back!");
}
else
{
    WriteLine("Please log in.");
}

// challenge 2: club or no 
WriteLine("what is your age?");
int myAge = int.Parse(ReadLine() ?? "0");
bool isTeenAge = false;

if (myAge >= 13) // true
{
    WriteLine("are you 18+ [true/false]");
    isTeenAge = Convert.ToBoolean(ReadLine()?.ToLower() ?? "false" ) == true ? true : false;
    if (isTeenAge)
    {
        WriteLine("go to club pal");
    }
    else
    {
        WriteLine("go to club with your parent");
    }
}
else
{
  WriteLine("go to kindergarden");
}

