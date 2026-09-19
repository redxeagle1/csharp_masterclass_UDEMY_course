#:property PublishAOT=false
using System.Collections;

// Predicate<int> isEvenAndDivisibleByFive = static x => (x % 2 == 0) && (x % 5 == 0);

// List<int> numbers = new List<int>(100);
// Random random = new();
// for(int i = 0; i < 100;i++)
// {
//     numbers.Add(random.Next(0,1000));
// }

// // List<int> molester = numbers.FindAll(isEvenAndDivisibleByFive);
// // foreach (var item in molester)
// // {
// //     Console.WriteLine(item);
// // }
// List<int> lessThanNumbers = numbers.Where(x => x < 100).ToList();

// foreach (var num in lessThanNumbers)
// {
//     Console.WriteLine(num);
// }


ArrayList myArrayList = new(100);
myArrayList.Add(3);
myArrayList.Add("1234");
myArrayList.Add(new int[] {1,2,3,4});

