using static System.Console;

/*
Create a simple C# program that initializes a 3x3 two-dimensional array with integers, calculates the sum of each row, and prints the sums to the console.

The program should:

Declare and initialize a 3x3 two-dimensional array with the following values:

1 2 3
4 5 6
7 8 9
Calculate the sum of each row in the array.

Print the sum of each row to the console.

Alert!

The result of execution for the default string should be:

6
15
24
*/

int[,] myTwoDimensionalArray =
{
    {1,2,3},
    {4,5,6},
    {7,8,9},
};

for (int row = 0; row <= myTwoDimensionalArray.GetUpperBound(0); row++)
{
    int sum = 0;
    for (int col = 0; col <= myTwoDimensionalArray.GetUpperBound(1); col++)
    {
        sum += myTwoDimensionalArray[row,col];
    }
    WriteLine(sum);
}