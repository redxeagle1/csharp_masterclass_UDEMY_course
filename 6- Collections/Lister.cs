#:property PublishAOT=false

Predicate<int> isEvenAndDivisibleByFive = static x => (x % 2 == 0) && (x % 5 == 0);
List<int> numbers = new List<int>(100);
Random random = new();
for(int i = 0; i < 100;i++)
{
    numbers.Add(random.Next(0,1000));
}

// List<int> molester = numbers.FindAll(isEvenAndDivisibleByFive);
// foreach (var item in molester)
// {
//     Console.WriteLine(item);
// }
