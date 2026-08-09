#:property PublishAot=false
using static System.Console;

#region ### getting the user input ###

Write("hey enter something:\t\t");
string? input = ReadLine(); // the "?" for null-coellising

WriteLine($"your {nameof(input)} is equal to {input}");
#endregion

#region ### you can add two or more string together in other world perform string concatination ###
WriteLine("===================================");
string a = "hello";
string b = " world";
string c = " my man";
WriteLine(a+b+c);
#endregion

ReadKey();


