using static System.Console;


// using static System.Console;
WriteLine("* Top-level functions example");
WhatsMyNamespace(); // Call the function.
void WhatsMyNamespace() // Define a local function.
{
  WriteLine("Namespace of Program class: {0}",
    arg0: typeof(Program).Namespace ?? "null");
}

// int a = 4;
// int b = 6;
// int result = SumOfTwo(a,b);
// WriteLine(result);
// WriteLine("please enter your name");
string myName = ReadLine() ?? "";
SayHello(myName);


void SayHello(string name)
{
    WriteLine($"hello mello mister {name}");
}

// int SumOfTwo(int firstNum, int secondNum)
// {
//     return firstNum + secondNum;
// }