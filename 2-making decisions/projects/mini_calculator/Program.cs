/*

Create a simple C# calculator program that performs basic arithmetic operations (+, -, *, /) based on user input.
The program should:

    1. Prompt the user to enter two numbers.
    2. Prompt the user to choose an arithmetic operation (Addition, Subtraction, Multiplication, Division).
    3. Use conditional statements to perform the selected operation.
    4. Print the result of the operation to the console.
    5. Handle division by zero with a specific message.
##################################

INPUT: 5, 3, +

EXPECTED OUTPUT

Enter the first number:
Enter the second number:
Choose an operation: +, -, *, /
Result: 8
*/

WriteLine("Enter the first number:");
decimal firstNum = decimal.TryParse(ReadLine()??"0",out decimal input) ? firstNum = input : firstNum = -1;
WriteLine("Enter the second number:");
decimal secondNum = decimal.TryParse(ReadLine()??"0",out input) ? secondNum = input : secondNum = -1;
WriteLine("Choose an operation: +, -, *, /");
string? operation_input = ReadLine()?.Trim();
char operation = operation_input?.Length  > 0 ? operation_input[0] : ' ';

switch (operation)
{
    case '+':
        secondNum = firstNum + secondNum;
        break;
    case '-':
        secondNum = firstNum - secondNum;
        break;
    case '*':
        secondNum = firstNum * secondNum;
        break;
    case '/':
        if(secondNum != 0)
        {
            secondNum = firstNum / secondNum; 
        break;
        }
        WriteLine("Error: Division by zero is not allowed.");
        return;
    default:
        WriteLine("Invalid operation. Please choose +, -, *, or /.");
        return;
}

WriteLine($"Result: {secondNum}");