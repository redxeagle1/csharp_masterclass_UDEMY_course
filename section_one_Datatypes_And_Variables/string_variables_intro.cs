#:property PublishAot=false
using static System.Console;


#region ### declaring a (string) variable which only only hold string literals ###
string myVar; // declaring a variable
myVar = "saad"; // assigning a variable

// must use what you have declared
WriteLine($"my variable is {nameof(myVar)} and its values is {myVar}");
#endregion


#region ## variable can be over-writing the variable value ###
// 
myVar = "hindi man";
WriteLine($"my variable is {nameof(myVar)} and its values is {myVar}");
#endregion


#region ### you can declare and assign a variabe as know as initialization !!! ###
// 
string mySecondVar = "hamada hadawy";
WriteLine(
    $"my variable is {nameof(mySecondVar)} and its values is {mySecondVar}"
);
#endregion

#region concatination in a string
int myba = 67;
string myfullname = "saad\t" + "admed\t" + myba;
WriteLine(myfullname); 
#endregion

#region string interpolation
WriteLine($"hello {myfullname} I think you like {67}");
ReadKey();
#endregion