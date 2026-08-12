#:property PublishAot=false
using static System.Console;
#region single dimensional arrays
// declaring arrays
int[] myIntArray = new int[5]; // declaring only
myIntArray[1] = 3;

double[] myDoubleArray = [12,21,21.3,21,21]; // initialization
 
string[] weekDays = ["sunday","monday","tuesday","wendnesday","thrusday","friday","saturday"];

foreach (var item in myIntArray)
{
    WriteLine($"{item} is in myIntArray");
}
WriteLine("\n\n########################################\n\n");
foreach (var item in myDoubleArray)
{
    WriteLine($"{item} is in myDoubleArray");
}
WriteLine("\n\n########################################\n\n");
foreach (var item in myIntArray)
{
    WriteLine($"{item} is in myIntArray");
}
WriteLine("\n\n########################################\n\n");
foreach (var item in weekDays)
{
    WriteLine($"{item} is in weekDays");
}
WriteLine("\n\n########################################\n\n");
double[] myDoubleArray2 = [12,21,21.3,21,21,12.4,132.23,21.3]; 
for (int index = 0; index < myDoubleArray2.Length; index++)
{
    WriteLine($"{myDoubleArray2[index]} is in {nameof(myDoubleArray2)}");
}
#endregion
#region multidimensional arrays
int[,] my2dArray = new int[3,3]; // declaration
my2dArray[0,0] = 1; // assignment
my2dArray[0,1] = 1;
int[,] myTwoDimensionalArrays= {    {1,3,4},    {8,0,23},   {12,29,12},  };

#endregion