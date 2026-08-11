#:property PublishAot=false
using static System.Console;

for (int i = 10; i >= 0; i--)
{
    WriteLine($"landing in {i}");
}
int a = 0;
hamada:
WriteLine("what am I doing {0}",a);
if (a != 5)
{
    a++;
    goto hamada;
}
else
{
    WriteLine("ending the program");
}