#:property PublishAOT=false
using static System.Console;

int a = 4;
int b = 6;
WriteLine($"{nameof(a)} [before] : {a}"); // a [before] : 4
int result = SumOfTwoDoubled(ref a,ref b);
WriteLine($"{nameof(a)} [after] : {a}"); // a [after] : 8
WriteLine(result);
WriteLine("please enter your name");
string myName = ReadLine() ?? "";
SayHello(myName);

void SayHello(string name)
{
    WriteLine($"hello mello mister {name}");
}

int SumOfTwoDoubled(ref int firstNum, ref int secondNum)
{
    firstNum *= 2;
    secondNum *= 2;
    return firstNum + secondNum;
}